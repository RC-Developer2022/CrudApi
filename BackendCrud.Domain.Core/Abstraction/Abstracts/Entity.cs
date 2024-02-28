using BackendCrud.Domain.Core.Structs;
using System.ComponentModel.DataAnnotations;

namespace BackendCrud.Domain.Core.Abstraction.Abstracts;
public abstract class Entity
{
    [Key]
    public CustomerId Id { get; set; } = CustomerId.Empty;
    public Entity()
    {
        Id = CustomerId.NewGuidCustomerId();
    }
}
