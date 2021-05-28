namespace Innobedded.KrankenHause.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Krank_Tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        EduID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.EduID);
            
            CreateTable(
                "dbo.Kranks",
                c => new
                    {
                        KrankID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Family = c.String(),
                        Address = c.String(),
                        Born = c.DateTime(nullable: false),
                        SexID = c.Int(nullable: false),
                        JobID = c.Int(nullable: false),
                        EduID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KrankID)
                .ForeignKey("dbo.Educations", t => t.EduID, cascadeDelete: true)
                .ForeignKey("dbo.Jobs", t => t.JobID, cascadeDelete: true)
                .ForeignKey("dbo.Sexes", t => t.SexID, cascadeDelete: true)
                .Index(t => t.SexID)
                .Index(t => t.JobID)
                .Index(t => t.EduID);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        JobID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.JobID);
            
            CreateTable(
                "dbo.Sexes",
                c => new
                    {
                        SexID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.SexID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kranks", "SexID", "dbo.Sexes");
            DropForeignKey("dbo.Kranks", "JobID", "dbo.Jobs");
            DropForeignKey("dbo.Kranks", "EduID", "dbo.Educations");
            DropIndex("dbo.Kranks", new[] { "EduID" });
            DropIndex("dbo.Kranks", new[] { "JobID" });
            DropIndex("dbo.Kranks", new[] { "SexID" });
            DropTable("dbo.Sexes");
            DropTable("dbo.Jobs");
            DropTable("dbo.Kranks");
            DropTable("dbo.Educations");
        }
    }
}
