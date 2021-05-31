using practica1parciallppa1.Data.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace practica1parciallppa1.Data
{
    public class CustomDbContext : DbContext
    {

        public DbSet<Afiliado> Afiliados { get; set; }

        
        public CustomDbContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}