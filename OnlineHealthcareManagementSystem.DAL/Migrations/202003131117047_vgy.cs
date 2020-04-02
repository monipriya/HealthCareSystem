namespace OnlineHealthcareManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vgy : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DoctorDetails", "Password", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DoctorDetails", "Password", c => c.String(nullable: false, maxLength: 15));
        }
    }
}
