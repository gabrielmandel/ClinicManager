using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stefanini_CRUD.Domain.Aggregate;

namespace Stefanini_CRUD.Infra.Data.Mapping
{
    public class CityEntityTypeConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City", "dbo");

            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).UseIdentityColumn();
            builder.Property(o => o.Name).IsRequired();
            builder.Property(o => o.UF).IsRequired();
        }
    }
}