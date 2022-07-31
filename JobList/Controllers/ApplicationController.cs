using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobList.Controllers
{
    public class ApplicationController : Controller
    {
        Context c = new Context();
        ApplicationManager applicationManager = new ApplicationManager(new EFApplicationDal());
        public IActionResult Index(int id)
        {
            var employerMail = User.Identity.Name;
            var employerID = c.Employers.Where(x => x.Mail == employerMail).Select(x => x.EmployerID).FirstOrDefault();
            var values = applicationManager.GetAllApplicationsWithER(id, employerID);
            return View(values);
            
        }
    }
}
