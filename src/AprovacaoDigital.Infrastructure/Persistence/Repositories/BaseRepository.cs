


using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Domain.Common;
using AprovacaoDigital.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
namespace AprovacaoDigital.Infrastructure.Persistence.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    protected readonly DbprojsemurContext Context;

    public BaseRepository(DbprojsemurContext context)
    {
        Context = context;
    }

    public void Create(T entity)
    {
        ////https://github.com/Amitpnk/Clean-Architecture-ASP.NET-Core/blob/develop/src/CleanArch.Persistence/Context/ApplicationDbContext.cs
       // entity.DateCreated = DateTimeOffset.UtcNow;
        Context.Add(entity);
    }

    public void Update(T entity)
    {
      //  entity.DateUpdated = DateTimeOffset.UtcNow;
        Context.Update(entity);
    }

    public void Delete(T entity)
    {
       // entity.DateDeleted = DateTimeOffset.UtcNow;
        Context.Update(entity);
    }
    public void ForceDelete(T entity)
    {
        Context.Remove(entity);
    }

    public async Task<T> Get(Expression<Func<T, bool>> filter, CancellationToken cancellationToken)
    {
        return await Context.Set<T>().AsNoTracking().FirstOrDefaultAsync(filter, cancellationToken);
    }

    public async Task<T> FindId(Expression<Func<T, bool>> filter, string includeProperties, CancellationToken cancellationToken)
    {
        var query = Context.Set<T>().AsQueryable();
        if (includeProperties != "")
        {
            query = includeProperties.Split(new char[] { ',' },
               StringSplitOptions.RemoveEmptyEntries).Aggregate(query, (current, includeProperty)
               => current.AsNoTracking().Include(includeProperty));
        }

        return await query.FirstOrDefaultAsync(filter, cancellationToken);
    }

    public async Task<ICollection<T>> GetAll(CancellationToken cancellationToken)
    {
        return await Context.Set<T>().AsNoTracking().ToListAsync(cancellationToken: cancellationToken);
    }
    public async Task<T> Find(Expression<Func<T, bool>> filter, CancellationToken cancellationToken, string? includeProperties)
    {
        IQueryable<T> query = Context.Set<T>().Where(filter);

        if (includeProperties != null)
        {
            query = includeProperties.Split(new char[] { ',' },
            StringSplitOptions.RemoveEmptyEntries).Aggregate(query, (current, includeProperty)
            => current.Include(includeProperty));
        }
        return await query.FirstOrDefaultAsync(cancellationToken);

    }
    public async Task<IEnumerable<T>> FindAll(Expression<Func<T, bool>> filter, CancellationToken cancellationToken)
    {
        return await Context.Set<T>().Where(filter).ToListAsync(cancellationToken: cancellationToken);
    }

    public IQueryable<T> FindQueryable(Expression<Func<T, bool>> expression,
    Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null)
    {
        IQueryable<T> query = Context.Set<T>().Where(expression);
        return orderBy != null ? orderBy(query) : query;
    }

    public Task<List<T>> FindListAsync(Expression<Func<T, bool>>? expression, Func<IQueryable<T>,
        IOrderedQueryable<T>>? orderBy = null, CancellationToken cancellationToken = default)
    {
        var query = expression != null ? Context.Set<T>().Where(expression) : Context.Set<T>();
        return orderBy != null
            ? orderBy(query).ToListAsync(cancellationToken)
            : query.ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> filter, string? includeProperties,
         Expression<Func<T, object>> orderByExpression, string direcao, CancellationToken cancellationToken)
    {

        IQueryable<T> query = Context.Set<T>();
        if (filter != null)
        {
            query = query.Where(filter);
        }

        if (includeProperties != null)
        {
            query = includeProperties.Split(new char[] { ',' },
            StringSplitOptions.RemoveEmptyEntries).Aggregate(query, (current, includeProperty)
            => current.Include(includeProperty));
        }
        if (orderByExpression != null)
        {
            // query = orderBy(query);
            if (direcao.ToLower() == "desc")
            {
                query = query.OrderByDescending(orderByExpression);
            }
            else
            {
                query = query.OrderBy(orderByExpression);
            }

        }
        else
        {
          //  query.OrderByDescending(o => o.Id);
        }

        return await query.ToListAsync(cancellationToken);
    }


    public Task<T?> SingleOrDefaultAsync(Expression<Func<T, bool>> expression, string? includeProperties)
    {
        var query = Context.Set<T>().AsQueryable();

        query = includeProperties.Split(new char[] { ',' },
            StringSplitOptions.RemoveEmptyEntries).Aggregate(query, (current, includeProperty)
            => current.Include(includeProperty));

        return query.SingleOrDefaultAsync(expression);
    }


}
