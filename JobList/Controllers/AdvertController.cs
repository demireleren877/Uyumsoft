using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Uyumsoft.Controllers
{

    public class AdvertController : Controller
    {

        AdvertManager advertManager = new AdvertManager(new EFAdvertDal());
        ApplicationManager applicationManager = new ApplicationManager(new EFApplicationDal());
        Context c = new Context();
        [HttpGet]
        public IActionResult Index()
        {

            var role = User.IsInRole("Employer");
            if (role)
            {
                var employer = c.Employers.Where(x => x.Mail == User.Identity.Name).FirstOrDefault();
                ViewBag.employer = employer;
                List<SelectListItem> sectors = (from x in c.Sectors.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = x.Name,
                                                    Value = x.SectorID.ToString()
                                                }).ToList();
                ViewBag.sctrs = sectors;
                List<SelectListItem> cities = (from x in c.Cities.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.CityID.ToString()
                                               }).ToList();
                ViewBag.cities = cities;
                List<SelectListItem> wayOfWorks = (from x in c.WayOfWorks.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.WayOfWorkID.ToString()
                                                   }).ToList();
                ViewBag.wyofwrks = wayOfWorks;
                List<SelectListItem> ohs = (from x in c.OnlineOrHybrids.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.Name,
                                                Value = x.OnlineHybridID.ToString()
                                            }).ToList();
                ViewBag.ohs = ohs;
                List<SelectListItem> competences = (from x in c.Competences.ToList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.CompetenceID.ToString()
                                                    }).ToList();
                ViewBag.competences = competences;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        [HttpPost]
        public IActionResult Index(Advert a)
        {
            var employerMail = User.Identity.Name;
            a.EmployerID = c.Employers.Where(x => x.Mail == employerMail).Select(x => x.EmployerID).FirstOrDefault();
            a.IsApproved = false;
            advertManager.AddAdvert(a);
            return RedirectToAction("Index", "Home");

        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult AdvertDetails(int id)
        {
            var advert = advertManager.GetByIdWithER(id);
            return View(advert);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult AdvertDetails(Application application)
        {
            var role = User.IsInRole("Employee");
            if (role)
            {
                var employeeMail = User.Identity.Name;
                var employeeID = c.Employees.Where(x => x.Mail == employeeMail).Select(x => x.EmployeeID).FirstOrDefault();
                application.EmployeeID = employeeID;
                application.AdvertID = Convert.ToInt32(@Url.ActionContext.RouteData.Values["id"].ToString());
                applicationManager.AddApplication(application);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public IActionResult AdvertsForUser(int id)
        {
            var role = User.IsInRole("Employer");
            var employerMail = User.Identity.Name;
            var employerID = c.Employers.Where(x => x.Mail == employerMail).Select(x => x.EmployerID).FirstOrDefault();
            if (role)
            {
                var values = advertManager.GetAllAdvertsByEmployerID(employerID);
                return View(values);
            }
            else
            {
                return RedirectToAction("Index", "Employee");
            }

        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult SearchAdverts()
        {
            List<SelectListItem> sectors = (from x in c.Sectors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.Name,
                                                Value = x.SectorID.ToString()
                                            }).ToList();
            ViewBag.sctrs = sectors;
            List<SelectListItem> cities = (from x in c.Cities.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.CityID.ToString()
                                           }).ToList();
            ViewBag.cities = cities;
            List<SelectListItem> wayOfWorks = (from x in c.WayOfWorks.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.WayOfWorkID.ToString()
                                               }).ToList();
            ViewBag.wyofwrks = wayOfWorks;
            List<SelectListItem> ohs = (from x in c.OnlineOrHybrids.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.Name,
                                            Value = x.OnlineHybridID.ToString()
                                        }).ToList();
            ViewBag.ohs = ohs;
            List<SelectListItem> competences = (from x in c.Competences.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = x.Name,
                                                    Value = x.CompetenceID.ToString()
                                                }).ToList();
            ViewBag.competences = competences;
            var adverts = advertManager.GetAllAdvertsWithEr();
            ViewBag.adverts = adverts;
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult SearchAdverts(Advert advert)
        {
            List<SelectListItem> sectors = (from x in c.Sectors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.Name,
                                                Value = x.SectorID.ToString()
                                            }).ToList();
            ViewBag.sctrs = sectors;
            List<SelectListItem> cities = (from x in c.Cities.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.CityID.ToString()
                                           }).ToList();
            ViewBag.cities = cities;
            List<SelectListItem> wayOfWorks = (from x in c.WayOfWorks.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.WayOfWorkID.ToString()
                                               }).ToList();
            ViewBag.wyofwrks = wayOfWorks;
            List<SelectListItem> ohs = (from x in c.OnlineOrHybrids.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.Name,
                                            Value = x.OnlineHybridID.ToString()
                                        }).ToList();
            ViewBag.ohs = ohs;
            List<SelectListItem> competences = (from x in c.Competences.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = x.Name,
                                                    Value = x.CompetenceID.ToString()
                                                }).ToList();
            ViewBag.competences = competences;
            ViewBag.adverts = advertManager.GetSearchedAdverts(advert);
            return View();
        }       

        public void DeleteAdvert(int id)
        {
            Advert advert = advertManager.GetById(id);
            advertManager.DeleteAdvert(advert);
        }
    }
}
