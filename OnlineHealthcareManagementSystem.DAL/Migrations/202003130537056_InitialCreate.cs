namespace OnlineHealthcareManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DoctorDetails",
                c => new
                    {
                        MailId = c.String(name: "Mail Id", nullable: false, maxLength: 50),
                        DoctorId = c.String(name: "Doctor Id"),
                        DoctorName = c.String(name: "Doctor Name", nullable: false, maxLength: 30),
                        DoctorSpecialist = c.String(name: "Doctor Specialist ", nullable: false, maxLength: 30),
                        Contactnumber = c.Long(name: "Contact number", nullable: false),
                        Password = c.String(nullable: false, maxLength: 15),
                        FromTime = c.DateTime(nullable: false),
                        ToTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MailId);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        MailId = c.String(name: "Mail Id", nullable: false, maxLength: 50),
                        PatientId = c.String(name: "Patient Id", nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 30),
                        Gender = c.String(nullable: false, maxLength: 6),
                        Dob = c.DateTime(nullable: false),
                        BloodGroup = c.String(name: "Blood Group", nullable: false, maxLength: 5),
                        Contactnumber = c.Long(name: "Contact number", nullable: false),
                        Location = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 15),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.MailId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accounts");
            DropTable("dbo.DoctorDetails");
        }
    }
}
