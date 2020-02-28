namespace OnlineHealthcareManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class column : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        MailId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        Sex = c.String(nullable: false),
                        Dob = c.DateTime(nullable: false),
                        BloodGroup = c.String(nullable: false),
                        MobileNumber = c.Long(nullable: false),
                        City = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MailId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accounts");
        }
    }
}
