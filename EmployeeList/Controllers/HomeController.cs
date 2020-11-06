using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmployeeList.Models;
using EmployeeList.Options;

namespace EmployeeList.Controllers
{
    public class HomeController : Controller
    {
        private IOption _option;

        public HomeController(IOption option)
        {
            _option = option;
        }

        public IActionResult Index(int page = 1)
        {
            _option.Initialize();
            return View(_option.GetPaginatedEmployees(5,page));
        }

        public IActionResult Edit(Employee newEmployee)
        {
            if (newEmployee.FullName != null || newEmployee.Position != null 
                || newEmployee.Characteristic != null)
            {
                _option.AddEmployee(newEmployee);
            }
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
