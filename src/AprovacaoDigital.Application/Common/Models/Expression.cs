using System.Linq.Expressions;
using System.Text;
namespace AprovacaoDigital.Application.Common.Models;
public static class ExpressionExtensions
{
    public static Expression<Func<T, bool>> AndAlso<T>(
        this Expression<Func<T, bool>> expr1,
        Expression<Func<T, bool>> expr2)
    {
        var parameter = Expression.Parameter(typeof(T));

        var leftVisitor = new ReplaceExpressionVisitor(expr1.Parameters[0], parameter);
        var left = leftVisitor.Visit(expr1.Body);

        var rightVisitor = new ReplaceExpressionVisitor(expr2.Parameters[0], parameter);
        var right = rightVisitor.Visit(expr2.Body);

        return Expression.Lambda<Func<T, bool>>(
            Expression.AndAlso(left, right), parameter);
    }

    public static Expression<Func<T, object>> CreateOrderByExpression<T>(string propertyName)
    {
        var parameter = Expression.Parameter(typeof(T), "entity");
        var property = Expression.Property(parameter, propertyName);
        var keySelector = Expression.Lambda<Func<T, object>>(Expression.Convert(property, typeof(object)), parameter);
        return keySelector;
    }
    public static Expression Replace(this Expression expression, Expression searchEx, Expression replaceEx)
    {
        return new ReplaceExpressionVisitor(searchEx, replaceEx).Visit(expression);
    }


}


public class ReplaceExpressionVisitor : ExpressionVisitor
{
    private readonly Expression _oldValue;
    private readonly Expression _newValue;

    public ReplaceExpressionVisitor(Expression oldValue, Expression newValue)
    {
        _oldValue = oldValue;
        _newValue = newValue;
    }


    public override Expression Visit(Expression node)
    {
        return node == _oldValue ? _newValue : base.Visit(node);
    }
}

public class FilterExpressionVisitor : ExpressionVisitor
{
    private StringBuilder _stringBuilder;
    private readonly object _parameterValues;

    public FilterExpressionVisitor(object parameterValues)
    {
        _parameterValues = parameterValues;
    }

    public string GetKey(Expression expression)
    {
        _stringBuilder = new StringBuilder();
        Visit(expression);
        return _stringBuilder.ToString();
    }

    protected override Expression VisitBinary(BinaryExpression node)
    {
        _stringBuilder.Append("(");
        Visit(node.Left);
        _stringBuilder.Append($" {node.NodeType} ");
        Visit(node.Right);
        _stringBuilder.Append(")");
        return node;
    }

    protected override Expression VisitMember(MemberExpression node)
    {
        if (node.Expression is ConstantExpression)
        {
            var value = GetValue(node);
            _stringBuilder.Append($"{node.Member.Name}={value}");
        }
        else
        {
            _stringBuilder.Append(node.Member.Name);
        }
        return node;
    }

    protected override Expression VisitConstant(ConstantExpression node)
    {
        _stringBuilder.Append(node.Value);
        return node;
    }

    private object GetValue(MemberExpression member)
    {
        var objectMember = Expression.Convert(member, typeof(object));
        var getterLambda = Expression.Lambda<Func<object>>(objectMember);
        var getter = getterLambda.Compile();
        return getter();
    }
}
