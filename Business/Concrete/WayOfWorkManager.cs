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
    public class WayOfWorkManager : IWayOfWorkService
    {
        IWayOfWorkDal _wayOfWorkDal;
        public WayOfWorkManager(IWayOfWorkDal wayOfWorkDal)
        {
            _wayOfWorkDal = wayOfWorkDal;
        }

        public List<WayOfWork> GetAll()
        {
            return _wayOfWorkDal.GetAll();
        }

        public WayOfWork GetById(int id)
        {
            return _wayOfWorkDal.Get(x => x.WayOfWorkID == id);
        }
    }
}
