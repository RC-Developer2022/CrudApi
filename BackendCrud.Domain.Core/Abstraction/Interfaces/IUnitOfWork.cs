namespace BackendCrud.Domain.Core.Abstraction.Interfaces;

public interface IUnitOfWork
{
    Task<bool> CommitAsync();

    Task RollbackAsync();
}
