namespace Innobedded.KrankenHause.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Family = c.String(),
                        FachID = c.Int(nullable: false),
                        Telefon = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.DoctorID)
                .ForeignKey("dbo.Faches", t => t.FachID, cascadeDelete: true)
                .Index(t => t.FachID);
            
            CreateTable(
                "dbo.Faches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "FachID", "dbo.Faches");
            DropIndex("dbo.Doctors", new[] { "FachID" });
            DropTable("dbo.Faches");
            DropTable("dbo.Doctors");
        }
    }
}
