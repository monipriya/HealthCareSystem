using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineHealthcareManagement.Entity
{
    public class Account
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        [Required]
        public long MobileNumber { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [Key]
        public string MailId { get; set; }
        [Required]
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
        //  public string ConfirmPassword { get; set; }

        public Account(string name, string sex, DateTime dob, string bloodGroup, long mobilenumber, string city, string mailID, string password)
        {
            this.Name = name;
            this.Sex = sex;
            this.Dob = dob;
            this.BloodGroup = bloodGroup;
            this.MobileNumber = mobilenumber;
            this.City = city;
            this.MailId = mailID;
            this.Password = password;
            
        }
        public Account()
        {

        }
    }
}


