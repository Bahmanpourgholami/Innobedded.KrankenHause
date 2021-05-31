namespace Innobedded.KrankenHause.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Set_Appointment_DbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Email = c.String(),
                        ReserveDate = c.DateTime(nullable: false),
                        Telefon = c.String(),
                        Description = c.String(maxLength: 350),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Appointments");
        }
    }
}
