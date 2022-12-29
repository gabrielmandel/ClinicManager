using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stefanini_CRUD.Domain.Aggregate;

namespace Stefanini_CRUD.Infra.Data.Mapping
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User", "dbo");

            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).UseIdentityColumn();
            builder.Property(o => o.Username).IsRequired();
            builder.Property(o => o.PasswordHash).IsRequired();
            builder.Property(o => o.PasswordSalt).IsRequired();
        }
    }
}