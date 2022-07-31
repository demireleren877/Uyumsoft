using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace Uyumsoft.Controllers
{
    [AllowAnonymous]
    public class Home : Controller
    {
        AdvertManager advertManager = new AdvertManager(new EFAdvertDal());
        EmployeeManager employeeManager = new EmployeeManager(new EFEmployeeDal());
        CityManager cityManager = new CityManager(new EFCityDal());
        WayOfWorkManager wayOfWorkManager = new WayOfWorkManager(new EFWayOfWorkDal());
        SectorManager sectorManager = new SectorManager(new EFSectorDal());
        public IActionResult Index()
        {            
            var adverts = advertManager.GetAllAdvertsWithEr();
            var employees = employeeManager.GetAllEmployeesWithCity();
            var cities = cityManager.GetAll();
            var wayOfWorks = wayOfWorkManager.GetAll();
            var sectors = sectorManager.GetAll();
            IndexVM model = new IndexVM();
            model.Adverts = adverts;
            model.Employees = employees;
            model.Cities = cities;
            model.Sectors = sectors;
            model.WayOfWorks = wayOfWorks;
            return View(model);
        }
    }
}
