using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineHealthcareManagement.Entity
{
    public class Account
    {
        [Column(name: "Patient Id")]
        public string PatientId { get; set; }
        [Required]
        [Column(name: "Name")]
        [MaxLength(30)] 
        public string Name { get; set; }
        [Required]
        [Column(name: "Gender")]
        [MaxLength(6)]
        public string Sex { get; set; }
        [Required]
        [Column(name: "Dob")]
        public DateTime Dob { get; set; }
        [Required]
        [Column(name: "Blood Group")]
        [MaxLength(5)]
        public string BloodGroup { get; set; }
        [Required]
        [Column(name:"Contact number")]
        public long MobileNumber { get; set; }
        [Required]
        [Column(name: "Location")]
        [MaxLength(20)]
        public string City { get; set; }
        [Required]
        [Key]
        [Column(name: "Mail Id")]
        [MaxLength(50)]
        public string MailId { get; set; }
        [Required]
        [Column(name:"Password")]
        [MaxLength(15)]
        public string Password { get; set; }
        private string role = "User";
        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                value = role;
            }
        }
        public static string GeneratePatientId(long mobileNumber, string name)
        {
            return "P" + mobileNumber.ToString().Substring(0, 2) + name.Substring(0, 4) ;
        }
        //public Account(string name, string sex, DateTime dob, string bloodGroup, long mobilenumber, string city, string mailID, string password)
        //{
        //    this.Name = name;
        //    this.Sex = sex;
        //    this.Dob = dob;
        //    this.BloodGroup = bloodGroup;
        //    this.MobileNumber = mobilenumber;
        //    this.City = city;
        //    this.MailId = mailID;
        //    this.Password = password;

        //}
        public Account()
        {

        }
    }
}


