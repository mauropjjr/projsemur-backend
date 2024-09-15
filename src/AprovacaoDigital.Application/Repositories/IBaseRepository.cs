using AprovacaoDigital.Domain.Common;
using System.Linq.Expressions;
namespace AprovacaoDigital.Application.Repositories;

public interface IBaseRepository<T> where T : BaseEntity
{
    void Detached(T entity);
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    void ForceDelete(T entity);
    void ForceDeleteRange(ICollection<T> entity);
    Task<T> Find(Expression<Func<T, bool>> filter, CancellationToken cancellationToken, string? includeProperties);
    Task<IEnumerable<T>> FindAll(Expression<Func<T, bool>> filter, CancellationToken cancellationToken);
    Task<T> Get(Expression<Func<T, bool>> filter, CancellationToken cancellationToken);
    Task<T> FindId(Expression<Func<T, bool>> filter, string? includeProperties, CancellationToken cancellationToken);
    Task<ICollection<T>> GetAll(CancellationToken cancellationToken);

    IQueryable<T> FindQueryable(Expression<Func<T, bool>> expression,
         Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null);

    Task<List<T>> FindListAsync(Expression<Func<T, bool>>? expression, Func<IQueryable<T>,
    IOrderedQueryable<T>>? orderBy = null, CancellationToken cancellationToken = default);
    Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> filter, string? includeProperties, Expression<Func<T, object>> orderByExpression, string direcao, CancellationToken cancellationToken);
    Task<T?> SingleOrDefaultAsync(Expression<Func<T, bool>> expression, string? includeProperties);

}
