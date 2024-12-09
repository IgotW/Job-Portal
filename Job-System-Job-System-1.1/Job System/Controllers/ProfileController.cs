using Microsoft.AspNetCore.Mvc;
using JobPortal.Models;

namespace JobPortal.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Candidate()
        {
            return View();
        }

        public IActionResult Company()
        {
            return View();
        }
    }
}