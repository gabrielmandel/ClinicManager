using Microsoft.EntityFrameworkCore;
using Stefanini_CRUD.Domain.Aggregate;
using Stefanini_CRUD.Infra.Data.Mapping;

namespace Stefanini_CRUD.Infra.Data
{
    /// <summary>
    /// Referência de artigo para conseguir criar modelos de configuração
    /// https://docs.microsoft.com/pt-br/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-implementation-entity-framework-core
    /// Rererência de artigo para conseguir criar migration a partir de dominios
    /// https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/managing?tabs=dotnet-core-cli
    /// </summary>
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<City> City { get; set; }
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Data Source=sqldata,1433;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=Stefanini@123");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonEntityTypeConfiguration());
            modelBuilder.Entity<Person>();
            modelBuilder.ApplyConfiguration(new CityEntityTypeConfiguration());
            modelBuilder.Entity<City>();
        }
    }
}
