namespace OnlineHealthcareManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class re : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.DoctorDetails");
            AlterColumn("dbo.DoctorDetails", "Mail Id", c => c.String(maxLength: 50));
            AlterColumn("dbo.DoctorDetails", "Doctor Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.DoctorDetails", "Doctor Id");
            CreateIndex("dbo.DoctorDetails", "Mail Id", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.DoctorDetails", new[] { "Mail Id" });
            DropPrimaryKey("dbo.DoctorDetails");
            AlterColumn("dbo.DoctorDetails", "Doctor Id", c => c.String());
            AlterColumn("dbo.DoctorDetails", "Mail Id", c => c.String(nullable: false, maxLength: 50));
            AddPrimaryKey("dbo.DoctorDetails", "Mail Id");
        }
    }
}
