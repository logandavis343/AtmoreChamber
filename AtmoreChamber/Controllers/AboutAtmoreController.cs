using AtmoreChamber.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AtmoreChamber.Controllers
{
    public class AboutAtmoreController : Controller
    {
        public IActionResult Index()
        {
            return View("OurHistory");
        }

        public IActionResult OurHistory()
        {
            return View("OurHistory");
        }

        public IActionResult OurCommunity()
        { 
            return View("OurCommunity");
        }

        public IActionResult RelocationandHelpfulResources()
        {
            return View("RelocationandHelpfulResources");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
