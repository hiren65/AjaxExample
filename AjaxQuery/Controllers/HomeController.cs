using System.Diagnostics;
using AjaxQuery.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxQuery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //Ajax Query
        [HttpPost]
        public int GetSum(int value11, int value22)
        {

            int dd = value11 + value22;


            return dd;
        }
       



    }
}
