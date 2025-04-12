using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult DashboardList()
        {
            return View();
        }
    }
}
