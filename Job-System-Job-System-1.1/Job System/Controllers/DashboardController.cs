using Microsoft.AspNetCore.Mvc;

namespace Job_System.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult CandidateDashboard()
        {
            return View();
        }

        public IActionResult CompanyDashboard()
        {
            return View();
        }
    }
}
