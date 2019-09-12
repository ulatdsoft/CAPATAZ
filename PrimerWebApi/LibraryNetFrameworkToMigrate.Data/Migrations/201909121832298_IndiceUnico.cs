namespace LibraryNetFrameworkToMigrate.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IndiceUnico : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personas", "Nombre", c => c.String(maxLength: 100));
            CreateIndex("dbo.Personas", "Nombre", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Personas", new[] { "Nombre" });
            AlterColumn("dbo.Personas", "Nombre", c => c.String());
        }
    }
}
