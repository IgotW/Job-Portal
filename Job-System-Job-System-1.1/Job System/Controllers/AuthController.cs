using Microsoft.AspNetCore.Mvc;
using JobPortal.Models;

namespace JobPortal.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult CandidateRegister()
        {
            return View();
        }

        public IActionResult CompanyRegister()
        {
            return View();
        }
    }
}