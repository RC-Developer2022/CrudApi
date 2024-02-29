using Backend.Domain.Core.Entities;
using BackendCrud.Infrastructure.Persistence.ConvertType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackendCrud.Infrastructure.Persistence.Context.Settings;

public sealed class PersonSettings : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasConversion(new CustomerIdConverter());
    }
}
