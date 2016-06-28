namespace DataQuiz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lenguajes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proyectoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Puesto = c.String(nullable: false),
                        NombreEmpreza = c.String(),
                        fecha = c.DateTime(nullable: false),
                        descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proyectoes");
            DropTable("dbo.Lenguajes");
        }
    }
}
