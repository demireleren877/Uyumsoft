using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployerManager : IEmployerService
    {
        IEmployerDal _employerDal;
        public EmployerManager(IEmployerDal employerDal)
        {
            _employerDal = employerDal;
        }

        public void AddEmployer(Employer employer)
        {
            _employerDal.Add(employer);
        }

        public void DeleteEmployer(Employer employer)
        {
            _employerDal.Delete(employer);
        }

        public List<Employer> GetAll()
        {
            return _employerDal.GetAll();
        }

        public Employer GetById(int id)
        {
            return _employerDal.Get(x=>x.EmployerID == id);
        }

        public void UpdateEmployer(Employer employer)
        {
            _employerDal.Update(employer);
        }
    }
}
