namespace LibraryNetFrameworkToMigrate.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryNetFrameworkToMigrateContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LibraryNetFrameworkToMigrateContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Personas.AddOrUpdate(new Persona() {Id = 1, Nombre = "Daniel N", Nacimiento = DateTime.Parse("05/06/1979 00:00:00") });
            context.Personas.AddOrUpdate(new Persona() {Id = 2, Nombre = "Mauricio U", Nacimiento = DateTime.Parse("11/06/1970 00:00:00") });
            context.SaveChanges();
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

        }
    }
}
