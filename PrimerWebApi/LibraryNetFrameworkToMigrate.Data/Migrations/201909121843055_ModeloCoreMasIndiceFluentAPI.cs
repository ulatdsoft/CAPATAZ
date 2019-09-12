namespace LibraryNetFrameworkToMigrate.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloCoreMasIndiceFluentAPI : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Personas", new[] { "Nombre" });
            CreateIndex("dbo.Personas", "Nombre", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Personas", new[] { "Nombre" });
            CreateIndex("dbo.Personas", "Nombre", unique: true);
        }
    }
}
