using Microsoft.AspNetCore.Mvc;

namespace AtmoreChamber.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}