using System.ComponentModel.DataAnnotations;

namespace Job_System.Models
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Industry { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string CompanyWebsite { get; set; }
        [Required]
        public string CompanyDescription { get; set; }
        public string Role { get; set; } = "Company";
    }
}
