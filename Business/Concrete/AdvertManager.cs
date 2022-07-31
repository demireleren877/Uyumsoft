using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdvertManager : IAdvertService
    {
        IAdvertDal _advertDal;
        public AdvertManager(IAdvertDal advertDal)
        {
            _advertDal = advertDal;

        }
        public void AddAdvert(Advert advert)
        {
            _advertDal.Add(advert);
        }

        public void DeleteAdvert(Advert advert)
        {
            _advertDal.Delete(advert);
        }

        public List<Advert> GetAll()
        {
            return _advertDal.GetAll();
        }

        public List<Advert> GetAllAdvertsByEmployeeID(int id)
        {
            return _advertDal.GetAllAdvertsByEmployeeID(id);
        }

        public List<Advert> GetAllAdvertsByEmployerID(int id)
        {
            return _advertDal.GetAllAdvertsByEmployerID(id);
        }

        public List<Advert> GetAllAdvertsWithEr()
        {
            return _advertDal.GetAllWithEr();
        }

        public List<Advert> GetAllAdvertsWithErForAdmin()
        {
            return _advertDal.GetAllWithErForAdmin();
        }

        public Advert GetById(int id)
        {
           return _advertDal.Get(p=>p.AdvertID==id);
        }

        public List<Advert> GetByIdWithER(int id)
        {
            return _advertDal.GetByIdWithER(id,x => x.AdvertID == id);
        }

        public List<Advert> GetSearchedAdverts(Advert advert)
        {
            return _advertDal.GetSearchedAdverts(advert);
        }

        public void UpdateAdvert(Advert advert)
        {
            _advertDal.Update(advert);
        }

    }
}
