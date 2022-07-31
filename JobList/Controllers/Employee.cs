using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Uyumsoft.Controllers
{
    public class Employee : Controller
    {
        AdvertManager advertManager = new AdvertManager(new EFAdvertDal());
        Context c = new Context();
        public IActionResult Index()
        {
            var employeeMail = User.Identity.Name;
            var employeeID = c.Employees.Where(x => x.Mail == employeeMail).Select(x => x.EmployeeID).FirstOrDefault();
            var values = advertManager.GetAllAdvertsByEmployeeID(employeeID);
            return View(values);
        }
    }
}
