using BackendCrud.Domain.Core.Abstraction.Abstracts;

namespace BackendCrud.Domain.Core.Abstraction.Interfaces;

public interface IRepositoryBase<TEntity> where TEntity : Entity
{
    Task AddAsync(TEntity etnity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);

}
