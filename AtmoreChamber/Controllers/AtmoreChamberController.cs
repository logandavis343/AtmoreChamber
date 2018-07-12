using AtmoreChamber.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AtmoreChamber.Controllers
{
    public class AtmoreChamberController : Controller
    {
        public IActionResult Index()
        {
            return View("ExecutiveBoard");
        }

        public IActionResult ExecutiveBoard()
        { 
            return View();
        }

        public IActionResult BoardOfDirectorsAndStaff()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
