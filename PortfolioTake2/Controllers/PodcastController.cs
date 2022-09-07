using Microsoft.AspNetCore.Mvc;

namespace PortfolioTake2.Controllers
{
    public class PodcastController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
