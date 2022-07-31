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
    public class OHManager : IOHService
    {
        IOHDal _ohDal;
        public OHManager(IOHDal ohDal)
        {
            _ohDal = ohDal;
        }

        public void AddOnlineOrHybrid(OnlineOrHybrid onlineOrHybrid)
        {
            _ohDal.Add(onlineOrHybrid);
        }

        public void DeleteOnlineOrHybrid(OnlineOrHybrid onlineOrHybrid)
        {
            _ohDal.Delete(onlineOrHybrid);
        }

        public List<OnlineOrHybrid> GetAll()
        {
            return _ohDal.GetAll();
        }        

        public OnlineOrHybrid GetById(int id)
        {
            return _ohDal.Get(x => x.OnlineHybridID == id);
        }

        public void UpdateOnlineOrHybrid(OnlineOrHybrid onlineOrHybrid)
        {
            _ohDal.Update(onlineOrHybrid);
        }
    }
}
