namespace Innobedded.KrankenHause.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServiceTable_Und_ServiceReceptionTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KlinikServicesReceptions",
                c => new
                    {
                        KSRID = c.Int(nullable: false, identity: true),
                        ServiceID = c.Int(nullable: false),
                        ReceptionID = c.Int(nullable: false),
                        ServiceCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KSRID)
                .ForeignKey("dbo.KlinikServices", t => t.ServiceID, cascadeDelete: true)
                .ForeignKey("dbo.Receptions", t => t.ReceptionID, cascadeDelete: true)
                .Index(t => t.ServiceID)
                .Index(t => t.ReceptionID);
            
            CreateTable(
                "dbo.KlinikServices",
                c => new
                    {
                        ServiceID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Picture = c.String(),
                        Cost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ServiceID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KlinikServicesReceptions", "ReceptionID", "dbo.Receptions");
            DropForeignKey("dbo.KlinikServicesReceptions", "ServiceID", "dbo.KlinikServices");
            DropIndex("dbo.KlinikServicesReceptions", new[] { "ReceptionID" });
            DropIndex("dbo.KlinikServicesReceptions", new[] { "ServiceID" });
            DropTable("dbo.KlinikServices");
            DropTable("dbo.KlinikServicesReceptions");
        }
    }
}
