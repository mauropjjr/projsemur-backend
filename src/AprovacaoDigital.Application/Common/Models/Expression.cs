using System.Linq.Expressions;
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

