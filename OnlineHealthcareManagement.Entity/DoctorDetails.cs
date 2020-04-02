using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineHealthcareManagement.Entity
{
    public class DoctorDetails
    { 
        [Key]
        [Column(name: "Doctor Id")]
        public string DoctorId { get; set; }
        [Required]
        [Column(name:"Doctor Name")]
        [MaxLength (30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        [Column(name: "Doctor Specialist ")]
        public string Specialist { get; set; }
        [Required]
        [Column(name: "Contact number")]
        public long MobileNumber { get; set; }
        [Index(IsUnique =true)]
        [Column(name: "Mail Id")]
        [MaxLength(50)]
        public string MailId { get; set; }
       
        [Column(name: "Password")]
        [MaxLength(15)]
        public string Password { get; set; }
        [Required]
        [Column(name: "FromTime")]
        public DateTime AvailableFromTime { get; set; }
        [Required]
        [Column(name: "ToTime")]
        public DateTime AvailableToTime { get; set; }

        public static string GenerateDoctorId(string name, long mobileNumber)
        {
            return "D" + mobileNumber.ToString().Substring(0, 2) + name.Substring(2, 4) + mobileNumber.ToString().Substring(4, 6) + name.Substring(0, 2);
        }
    }
    
}
