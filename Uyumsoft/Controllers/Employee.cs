using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Uyumsoft.Controllers
{
    public class Employee : Controller
    {
        EmployeeManager employeeManager = new EmployeeManager(new EFEmployeeDal());
        public IActionResult Index()
        {
            var values = employeeManager.GetAllEmployeesWithCity();
            return View(values);
        }
    }
}
