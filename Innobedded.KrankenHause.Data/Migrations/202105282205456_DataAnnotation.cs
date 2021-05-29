namespace Innobedded.KrankenHause.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Doctors", "Description", c => c.String(maxLength: 350));
            AlterColumn("dbo.Kliniks", "Description", c => c.String(maxLength: 350));
            AlterColumn("dbo.KlinikServices", "Description", c => c.String(maxLength: 350));
            AlterColumn("dbo.Kranks", "Address", c => c.String(maxLength: 300));
            AlterColumn("dbo.Kranks", "Description", c => c.String(maxLength: 350));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kranks", "Description", c => c.String());
            AlterColumn("dbo.Kranks", "Address", c => c.String());
            AlterColumn("dbo.KlinikServices", "Description", c => c.String());
            AlterColumn("dbo.Kliniks", "Description", c => c.String());
            AlterColumn("dbo.Doctors", "Description", c => c.String());
        }
    }
}
