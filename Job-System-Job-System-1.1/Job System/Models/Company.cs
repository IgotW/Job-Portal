using System.ComponentModel.DataAnnotations;

namespace Job_System.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Industry { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyDescription { get; set; }
    }
}
