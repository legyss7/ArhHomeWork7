using Microsoft.AspNetCore.Mvc;
using SPAWebApplication.Models;

namespace SPAWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee
            {
                Name = "Oleg",
                Age = 30,
                Id = 10001
            });
            employee.Add(new Employee
            {
                Name = "Masha",
                Age = 34,
                Id = 10002
            });
            employee.Add(new Employee
            {
                Name = "Dima",
                Age = 39,
                Id = 10003
            });
            return View(employee);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
