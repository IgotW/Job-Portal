using Microsoft.AspNetCore.Mvc;
using JobPortal.Models;

namespace JobPortal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Jobs()
        {
            var jobs = new List<Job>
            {
                new Job
                {
                    Id = 1,
                    Title = "Senior .NET Developer",
                    Company = "Tech Corp",
                    Location = "New York, NY",
                    Type = "Full-time",
                    Salary = "$120k - $150k",
                    Description = "Looking for an experienced .NET developer...",
                    PostedDate = DateTime.Now.AddDays(-2)
                },
                new Job
                {
                    Id = 2,
                    Title = "UX Designer",
                    Company = "Design Studio",
                    Location = "Remote",
                    Type = "Full-time",
                    Salary = "$90k - $120k",
                    Description = "Seeking a talented UX designer...",
                    PostedDate = DateTime.Now.AddDays(-1)
                }
            };

            return View(jobs);
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}