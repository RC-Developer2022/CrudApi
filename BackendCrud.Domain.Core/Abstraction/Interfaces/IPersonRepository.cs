using Backend.Domain.Core.Entities;
using BackendCrud.Domain.Core.Structs;

namespace BackendCrud.Domain.Core.Abstraction.Interfaces;

public interface IPersonRepository
{
    Task<IEnumerable<Person>> GetAllPerson();
    Task<IEnumerable<Person>> GetPersonByName(string name);
    Task<Person> GetPersonById(CustomerId customerId);
}
