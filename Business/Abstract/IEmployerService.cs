using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployerService
    {
        List<Employer> GetAll();
        Employer GetById(int id);
        void AddEmployer(Employer employer);
        void DeleteEmployer(Employer employer);
        void UpdateEmployer(Employer employer);
    }
}
