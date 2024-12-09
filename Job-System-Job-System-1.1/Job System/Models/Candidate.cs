using System.ComponentModel.DataAnnotations;

namespace Job_System.Models
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Profession { get; set; }
        public string YearsofExperience { get; set; }
        public string ProfessionSummary { get; set; }
    }
}
