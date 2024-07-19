using AprovacaoDigital.Infrastructure.Persistence.Context;

using AprovacaoDigital.Application.Repositories;
namespace AprovacaoDigital.Infrastructure.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly DbprojsemurContext _context;
    private bool _disposed;

    public UnitOfWork(DbprojsemurContext context)
    {
        _context = context;
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    public Task Save(CancellationToken cancellationToken)
    {
        return _context.SaveChangesAsync(cancellationToken);
    }
    ~UnitOfWork()
    {
        Dispose(false);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
            if (disposing)
                _context.Dispose();
        _disposed = true;
    }
}