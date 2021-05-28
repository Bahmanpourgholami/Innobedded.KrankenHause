namespace Innobedded.KrankenHause.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Klinik_tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kliniks",
                c => new
                    {
                        KlinikID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        KlinikTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KlinikID)
                .ForeignKey("dbo.KlinikTypes", t => t.KlinikTypeID, cascadeDelete: true)
                .Index(t => t.KlinikTypeID);
            
            CreateTable(
                "dbo.KlinikTypes",
                c => new
                    {
                        KlinikTypeID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.KlinikTypeID);
            
            CreateTable(
                "dbo.Insurances",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Doctors", "KlinikID", c => c.Int(nullable: false));
            AddColumn("dbo.Kranks", "InsuranceID", c => c.Int(nullable: false));
            CreateIndex("dbo.Doctors", "KlinikID");
            CreateIndex("dbo.Kranks", "InsuranceID");
            AddForeignKey("dbo.Doctors", "KlinikID", "dbo.Kliniks", "KlinikID", cascadeDelete: true);
            AddForeignKey("dbo.Kranks", "InsuranceID", "dbo.Insurances", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kranks", "InsuranceID", "dbo.Insurances");
            DropForeignKey("dbo.Kliniks", "KlinikTypeID", "dbo.KlinikTypes");
            DropForeignKey("dbo.Doctors", "KlinikID", "dbo.Kliniks");
            DropIndex("dbo.Kranks", new[] { "InsuranceID" });
            DropIndex("dbo.Kliniks", new[] { "KlinikTypeID" });
            DropIndex("dbo.Doctors", new[] { "KlinikID" });
            DropColumn("dbo.Kranks", "InsuranceID");
            DropColumn("dbo.Doctors", "KlinikID");
            DropTable("dbo.Insurances");
            DropTable("dbo.KlinikTypes");
            DropTable("dbo.Kliniks");
        }
    }
}
