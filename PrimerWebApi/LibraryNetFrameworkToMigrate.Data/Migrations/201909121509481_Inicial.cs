namespace LibraryNetFrameworkToMigrate.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personas",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nombre = c.String(),
                    Nacimiento = c.DateTime(nullable: false),
                    Papa_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personas", t => t.Papa_Id)
                .Index(t => t.Papa_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Personas", "Papa_Id", "dbo.Personas");
            DropIndex("dbo.Personas", new[] { "Papa_Id" });
            DropTable("dbo.Personas");
        }
    }
}
