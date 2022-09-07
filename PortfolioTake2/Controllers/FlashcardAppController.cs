using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioTake2.Models;
using System.Diagnostics;

namespace PortfolioTake2.Controllers
{
    public class FlashcardAppController : Controller
    {
        public IActionResult Landing()
        {
            return View();
        }

        [Authorize]
        public IActionResult SetView()
        {
            return View();
        }
    }
}
