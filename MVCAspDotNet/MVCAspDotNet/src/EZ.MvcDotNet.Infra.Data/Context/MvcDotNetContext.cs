using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EZ.MvcDotNet.Domain.Entities;
using EZ.MvcDotNet.Infra.Data.EntityConfig;

namespace EZ.MvcDotNet.Infra.Data.Context
{
    public class MvcDotNetContext : DbContext
    {
        public MvcDotNetContext()
            : base("MvcDotNetContext")
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // General Custom Context Properties
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
