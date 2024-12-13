using System.ComponentModel.DataAnnotations;

namespace Job_System.Models
{
    public class Candidate
    {
        [Key]
        public int CandidateID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string YearsofExperience { get; set; }
        [Required]
        public string ProfessionSummary { get; set; }
        public string Role { get; set; } = "Candidate";
    }
}
