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
    public class SectorManager : ISectorService
    {
        ISectorDal _sectorDal;
        public SectorManager(ISectorDal sectorDal)
        {
            _sectorDal = sectorDal;
        }

        public List<Sector> GetAll()
        {
            return _sectorDal.GetAll();
        }

        public Sector GetById(int id)
        {
            return _sectorDal.Get(x => x.SectorID == id);
        }
    }
}
