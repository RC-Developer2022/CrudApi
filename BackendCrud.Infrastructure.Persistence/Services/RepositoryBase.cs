using BackendCrud.Data;
using BackendCrud.Domain.Core.Abstraction.Abstracts;
using BackendCrud.Domain.Core.Abstraction.Interfaces;

namespace BackendCrud.Infrastructure.Persistence.Services;

public sealed class RepositoryBase<TEntity>(AppDbContext context) : IRepositoryBase<TEntity> where TEntity : Entity
{
    private readonly AppDbContext _context = context;

    public async Task AddAsync(TEntity etnity) 
        => await _context.AddAsync(etnity);

    public async Task DeleteAsync(TEntity entity) 
        => _context.Remove(entity);

    public async Task UpdateAsync(TEntity entity) 
        => _context.Update(entity);
}
