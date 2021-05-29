namespace Innobedded.KrankenHause.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Krank_table_changed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Faches", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.KlinikTypes", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Educations", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Insurances", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Jobs", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Sexes", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sexes", "Title", c => c.String());
            AlterColumn("dbo.Jobs", "Title", c => c.String());
            AlterColumn("dbo.Insurances", "Title", c => c.String());
            AlterColumn("dbo.Educations", "Title", c => c.String());
            AlterColumn("dbo.KlinikTypes", "Title", c => c.String());
            AlterColumn("dbo.Faches", "Title", c => c.String());
        }
    }
}
