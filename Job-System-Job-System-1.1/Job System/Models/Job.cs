using System.ComponentModel.DataAnnotations;

namespace JobPortal.Models
{
    public class Job
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Job Title")]
        public string Title { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Job Type")]
        public string Type { get; set; }

        public string Salary { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime PostedDate { get; set; }
    }
}