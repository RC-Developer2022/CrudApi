using Backend.Domain.Core.Entities;
using BackendCrud.Data;
using BackendCrud.Domain.Core.Abstraction.Interfaces;
using BackendCrud.Domain.Core.Structs;
using Microsoft.EntityFrameworkCore;

namespace BackendCrud.Infrastructure.Persistence.Services;

public sealed class PersonRepository(AppDbContext context) : IPersonRepository
{
    private readonly AppDbContext _context = context;

    public async Task<IEnumerable<Person>> GetAllPerson() 
        => await _context.People.ToListAsync();

    public async Task<IEnumerable<Person>> GetPersonByName(string name) 
        => await _context.People.Where(p => p.Nome.Equals(name)).ToListAsync();

    public async Task<Person> GetPersonById(CustomerId customerId) 
        => await _context.People.Where(p => p.Id.Equals(customerId)).FirstOrDefaultAsync();
}
