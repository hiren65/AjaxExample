using AjaxQuery.Models;
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



        public IActionResult createEmployee()
        {
            return View("createEmp");
        }
        [HttpPost]
        public Employee createEmployee(Employee emp)
        {
            //Save employee to database
            Employee employee = new Employee();
            employee.Phone = emp.Phone;
            employee.Name = emp.Name;
            employee.Email = emp.Email;

            return  (employee);
        }



    }
}
