using Microsoft.EntityFrameworkCore.Storage;

namespace BackendCrud.Domain.Core.Abstraction.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IDbContextTransaction BeginTransaction();
    Task<bool> CommitAsync();
    Task RollbackAsync();
}
