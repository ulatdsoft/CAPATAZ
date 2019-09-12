using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryNetFrameworkToMigrate.Data
{
    public class LibraryNetFrameworkToMigrateContext : DbContext
    {
        public LibraryNetFrameworkToMigrateContext() : base("LibraryNetFrameworkToMigrate")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<LibraryNetFrameworkToMigrateContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>().HasIndex(b => b.Nombre).IsUnique();
        }


        public DbSet<Persona> Personas { get; set; }

    }
}
