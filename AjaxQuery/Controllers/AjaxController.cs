using Microsoft.AspNetCore.Mvc;

namespace AjaxQuery.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public int GetSum(int value11, int value22)
        {
            int dd = value11 + value22;
            return dd;
        }


    }
}
