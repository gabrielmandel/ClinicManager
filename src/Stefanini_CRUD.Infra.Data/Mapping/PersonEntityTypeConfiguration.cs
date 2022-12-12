using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Stefanini_CRUD.Infra.Data.Mapping
{
    public class PersonEntityTypeConfiguration : IEntityTypeConfiguration<Stefanini_CRUD.Domain.Aggregate.Person>
    {
        public void Configure(EntityTypeBuilder<Stefanini_CRUD.Domain.Aggregate.Person> builder)
        {
            builder.ToTable("Person", "dbo");

            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).UseIdentityColumn();
            builder.Property(o => o.Name).IsRequired();
            builder.Property(o => o.Age).IsRequired();
            builder.Property(o => o.Id_City).IsRequired();

            builder.HasOne(p => p.City)
                    .WithMany()
                    .HasForeignKey(p => p.Id_City)
                    .HasPrincipalKey(c => c.Id);
        }
    }
}