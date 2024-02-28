using BackendCrud.Domain.Core.Abstraction.Abstracts;

namespace Backend.Domain.Core.Entities;

public class Person : Entity
{

    public string Nome { get; set; }
    public int Idade { get; set; }

    public Person()
    {
    }
}
