using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WafferlyBackEnd.Models;

namespace WafferlyBackEnd.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Login(){
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
