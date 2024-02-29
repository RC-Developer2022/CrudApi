using BackendCrud.Domain.Core.Structs;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackendCrud.Infrastructure.Persistence.ConvertType;

public class CustomerIdConverter : ValueConverter<CustomerId, Guid>
{
    public CustomerIdConverter(ConverterMappingHints mappingHints = null)
        : base(
            id => id.value,
            value => new CustomerId(value),
            mappingHints)
    { }

}