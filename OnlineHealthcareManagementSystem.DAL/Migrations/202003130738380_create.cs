namespace OnlineHealthcareManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "Patient Id", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "Patient Id", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
