using System.Data.Entity;
using EZ.MvcDotNet.Domain.Entities;

namespace EZ.MvcDotNet.Infra.Data.Context
{
    class MvcDotNetContext : DbContext
    {
        public MvcDotNetContext()
            : base("MvcDotNetContext")
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
