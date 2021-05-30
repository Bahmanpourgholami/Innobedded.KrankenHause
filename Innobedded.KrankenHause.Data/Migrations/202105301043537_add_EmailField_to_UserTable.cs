namespace Innobedded.KrankenHause.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_EmailField_to_UserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Email");
        }
    }
}
