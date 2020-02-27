using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineHealthcareManagement.Entity
{
    public class Account
        {
            public string Name { get; set; }
            public string Sex { get; set; }
            public DateTime Dob { get; set; }
            public string BloodGroup { get; set; }
            public long MobileNumber { get; set; }
            public string City { get; set; }
            public string MailId { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }

        public Account(string name, string sex, DateTime dob, string bloodGroup, long mobilenumber, string city, string mailID, string password, string confirmPassword)
        {
            this.Name = name;
            this.Sex = sex;
            this.Dob = dob;
            this.BloodGroup = bloodGroup;
            this.MobileNumber = mobilenumber;
            this.City = city;
            this.MailId = mailID;
            this.Password = password;
            this.ConfirmPassword = confirmPassword;
        }
      
        }
    }


