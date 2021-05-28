namespace Innobedded.KrankenHause.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsersTables_and_ReceptionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Receptions",
                c => new
                    {
                        ReceptionID = c.Int(nullable: false, identity: true),
                        KrankID = c.Int(nullable: false),
                        KlinikID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        Accept = c.Boolean(nullable: false),
                        CauseDescription = c.String(),
                        ReceptionTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReceptionID)
                .ForeignKey("dbo.Kliniks", t => t.KlinikID, cascadeDelete: true)
                .ForeignKey("dbo.Kranks", t => t.KrankID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.KrankID)
                .Index(t => t.KlinikID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        NameFamily = c.String(),
                        LastEnter = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            AddColumn("dbo.Doctors", "Description", c => c.String());
            AddColumn("dbo.Doctors", "Picture", c => c.String());
            AddColumn("dbo.Kliniks", "Description", c => c.String());
            AddColumn("dbo.Kliniks", "Picture", c => c.String());
            AddColumn("dbo.Kranks", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Receptions", "UserID", "dbo.Users");
            DropForeignKey("dbo.Receptions", "KrankID", "dbo.Kranks");
            DropForeignKey("dbo.Receptions", "KlinikID", "dbo.Kliniks");
            DropIndex("dbo.Receptions", new[] { "UserID" });
            DropIndex("dbo.Receptions", new[] { "KlinikID" });
            DropIndex("dbo.Receptions", new[] { "KrankID" });
            DropColumn("dbo.Kranks", "Description");
            DropColumn("dbo.Kliniks", "Picture");
            DropColumn("dbo.Kliniks", "Description");
            DropColumn("dbo.Doctors", "Picture");
            DropColumn("dbo.Doctors", "Description");
            DropTable("dbo.Users");
            DropTable("dbo.Receptions");
        }
    }
}
