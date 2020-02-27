using System.ComponentModel.DataAnnotations;

namespace OnlineHealthcareManagementMVC.Models
{
    public class SigInModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}