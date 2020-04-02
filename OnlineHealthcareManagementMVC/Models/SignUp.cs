using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineHealthcareManagementMVC.Models
{
    public class SignUp
    {
        [DataType(DataType.Text)]
        [MaxLength(35)]
        [Required(ErrorMessage = "Please enter your first name")]
        [RegularExpression("[A-Z][a-z][^(@#&<>~;$^%{}?][^0-9]{0,35}", ErrorMessage = "Please enter a valid first name")]
        [Display(Name = "UserName")]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please selct the gender")]
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
        [RegularExpression("^[6-9][0-9]{9}$", ErrorMessage = "Please enter a valid mobile number")]
        public long MobileNumber { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Enter the city")]
        public string City { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Enter the email address")]
        public string MailId { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter the password")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Those password didn't match, Try again ")]
        public string ConfirmPassword { get; set; }
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

        public SignUp()
        {

        }
    }
}
