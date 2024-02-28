namespace BackendCrud.Domain.Core.Abstraction.Interfaces;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    Task<TEntity> AddAsync(TEntity etnity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task<TEntity> DeleteAsync(TEntity entity);

}
