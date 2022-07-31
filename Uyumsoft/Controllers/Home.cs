using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace Uyumsoft.Controllers
{
    public class Home : Controller
    {
        AdvertManager advertManager = new AdvertManager(new EFAdvertDal());
        EmployeeManager employeeManager = new EmployeeManager(new EFEmployeeDal());
        CityManager cityManager = new CityManager(new EFCityDal());
        public IActionResult Index()
        {            
            var adverts = advertManager.GetAllAdvertsWithEr();
            var employees = employeeManager.GetAllEmployeesWithCity();
            var cities = cityManager.GetAll();
            IndexVM model = new IndexVM();
            model.Adverts = adverts;
            model.Employees = employees;
            model.Cities = cities;
            return View(model);
        }
    }
}
