using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineHealthcareManagementMVC.Models
{
    public class UserDetails
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter the name"), MaxLength(30)]
        [Display(Name = "UserName")]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please select the gender")]
        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please select the Date of birth")]
        [Display(Name = "Dob")]
        public DateTime Dob { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Enter the blood group")]
        [Display(Name = "BloodGroup")]
        public string BloodGroup { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Enter the number")]
        public long MobileNumber { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Enter the city")]
        public string City { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Enter the email address")]
        [Key]
        public string MailId { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter the password")]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }

        //public UserDetails(string name, string sex, DateTime dob, string bloodGroup, long mobilenumber, string city, string mailID, string password)
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
        public UserDetails()
        {

        }
    }
}
