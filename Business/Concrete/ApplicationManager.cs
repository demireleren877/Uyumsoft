using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApplicationManager : IApplicationService
    {
        IApplicationDal _applicationDal;
        public ApplicationManager(IApplicationDal applicationDal)
        {
            _applicationDal = applicationDal;
        }

        public void AddApplication(Application application)
        {
            Context context = new Context();
            var isExist = context.Applications.Any(x => x.AdvertID == application.AdvertID && x.EmployeeID == application.EmployeeID);
            if (!isExist)
            {
                _applicationDal.Add(application);
            }
        }

        public void DeleteApplication(Application application)
        {
            _applicationDal.Delete(application);
        }

        public List<Application> GetAll()
        {
            return _applicationDal.GetAll();
        }

        public List<Application> GetAllApplicationsWithER(int id,int employerid)
        {
            return _applicationDal.GetAllWithEr(id,employerid);
        }

        public Application GetById(int id)
        {
            return _applicationDal.Get(x=>x.ApplicationID==id);
        }

        public void UpdateApplication(Application application)
        {
            _applicationDal.Update(application);
        }
    }
}
