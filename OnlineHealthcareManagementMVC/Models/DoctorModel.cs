using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineHealthcareManagementMVC.Models
{
    public class DoctorModel
    {
        [DataType(DataType.Text)]
        [MaxLength(35)]
        [Required(ErrorMessage = "Please enter the doctor name")]
        [RegularExpression("[A-Z][a-z][^(@#&<>~;$^%{}?][^0-9]{0,35}", ErrorMessage = "Please enter a valid name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please add the specialist")]
        [Display(Name = "Specialist")]
        public string Specialist { get; set; }

        [Required(ErrorMessage = "Please enter the contact number")]
        [RegularExpression("^[6-9][0-9]{9}$", ErrorMessage = "Please enter a valid mobile number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter a valid mobile number")]
        public long MobileNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Enter the email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [MaxLength(64)]
        public string MailId { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter the password")]
        [RegularExpression("((?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()]).{6,15})", ErrorMessage = "Password must be at least 8 characters long, contain at least one number and have a mixture of uppercase and lowercase letters.")]
        [MaxLength(15)]
        [MinLength(6)]
        public string Password { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Enter the available from time")]
        public DateTime AvailableFromTime { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Enter the available to time")]
        public DateTime AvailableToTime { get; set; }
    }
}