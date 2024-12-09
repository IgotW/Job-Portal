using Microsoft.AspNetCore.Mvc;
using JobPortal.Models;

namespace JobPortal.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Post()
        {
            return View();
        }

        public IActionResult Manage()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            //later on, we would fetch the job details from the database na haa sampol lang ni
            var job = new Job
            {
                Id = id,
                Title = "Senior Software Engineer",
                Company = "Tech Corp",
                Location = "New York, NY",
                Type = "Full-time",
                Salary = "$120k - $150k",
                Description = "We are looking for an experienced software engineer to join our team...",
                PostedDate = DateTime.Now.AddDays(-2)
            };

            return View(job);
        }

        public IActionResult Apply(int id)
        {
            //later on, we would fetch the job details from the database na haa sampol lang ni
            ViewBag.JobId = id;
            return View();
        }
    }
}