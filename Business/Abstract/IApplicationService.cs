using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicationService
    {
        List<Application> GetAll();
        Application GetById(int id);
        void AddApplication(Application application);
        void DeleteApplication(Application application);
        void UpdateApplication(Application application);
        List<Application> GetAllApplicationsWithER(int id,int employerid);
    }
}
