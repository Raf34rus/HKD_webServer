using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HKD_WebServer.Models;
using Microsoft.AspNetCore.Authorization;

namespace HKD_WebServer.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            ViewBag.stylehref = "https://cdn.jsdelivr.net/npm/@mdi/font@latest/css/materialdesignicons.min.css";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
