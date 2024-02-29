using BackendCrud.Data;
using BackendCrud.Domain.Core.Abstraction.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace BackendCrud.Infrastructure.Persistence.Services;

public sealed class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private IDbContextTransaction _transaction;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public IDbContextTransaction BeginTransaction()
    {
        _transaction = _context.Database.BeginTransaction();
        return _transaction;
    }

    public async Task<bool> CommitAsync()
    {
        try
        {
            await _transaction.CommitAsync();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
            _transaction?.Dispose();
            return false;
        }
        finally
        {
            _transaction = null;
        }
    }

    public Task RollbackAsync()
    {
        _transaction?.Rollback();
        _transaction?.Dispose();
        _transaction = null;
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
