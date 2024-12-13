using Microsoft.AspNetCore.Mvc;
using JobPortal.Models;
using Job_System.Data;
using Job_System.Models;

namespace JobPortal.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AuthController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Login()
        {
<<<<<<< Updated upstream
=======

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string password)
        {
            // Check for a Candidate
            var candidate = _db.Candidates
                .FirstOrDefault(c => c.Email == email && c.Password == password);

            if (candidate != null && candidate.Role == "Candidate")
            {
                // Store role in session
                //HttpContext.Session.SetString("UserRole", "Candidate");

                // Redirect to Candidate Dashboard
                return RedirectToAction("CandidateDashboard", "Dashboard");
            }

            // Check for a Company
            var company = _db.Companies
                .FirstOrDefault(c => c.Email == email && c.Password == password);

            if (company != null && company.Role == "Company")
            {
                // Store role in session
                //HttpContext.Session.SetString("UserRole", "Company");

                // Redirect to Company Dashboard
                return RedirectToAction("CompanyDashboard", "Dashboard");
            }

            // If no match is found, display an error message
            ViewBag.ErrorMessage = "Invalid email or password.";
>>>>>>> Stashed changes
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CandidateRegister(Candidate obj)
        {
            if (ModelState.IsValid)
            {
                _db.Candidates.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(obj);
        }

        public IActionResult CompanyRegister()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CompanyRegister(Company obj)
        {
            if (ModelState.IsValid)
            {
                _db.Companies.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(obj);
        }
        //public IActionResult CandidateDashboard()
        //{
        //    if (HttpContext.Session.GetString("UserRole") != "Candidate")
        //    {
        //        return RedirectToAction("Login", "Auth");
        //    }
        //    return View();
        //}
        //public IActionResult CompanyDashboard()
        //{
        //    if (HttpContext.Session.GetString("UserRole") != "Company")
        //    {
        //        return RedirectToAction("Login", "Auth");
        //    }
        //    return View();
        //}
    }
}