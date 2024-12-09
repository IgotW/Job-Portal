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

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string password)
        {
            // Check for a matching candidate
            var candidate = _db.Candidates
                .FirstOrDefault(c => c.Email == email && c.Password == password);

            if (candidate != null)
            {
                // Redirect to Candidate Dashboard (or any other view)
                return RedirectToAction("CandidateDashboard", "Dashboard");
            }

            // Check for a matching company
            var company = _db.Companies
                .FirstOrDefault(c => c.Email == email && c.Password == password);

            if (company != null)
            {
                // Redirect to Company Dashboard (or any other view)
                return RedirectToAction("CompanyDashboard", "Dashboard");
            }

            // If no match is found, display an error message
            ViewBag.ErrorMessage = "Invalid email or password.";
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
    }
}