using Microsoft.AspNetCore.Mvc;

namespace PortfolioTake2.Controllers
{
    public class TravelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
