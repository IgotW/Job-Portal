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