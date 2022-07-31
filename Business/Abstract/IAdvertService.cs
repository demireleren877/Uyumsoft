using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdvertService
    {
        List<Advert> GetAll();
        Advert GetById(int id);
        List<Advert> GetByIdWithER(int id);
        void AddAdvert(Advert advert);
        void DeleteAdvert(Advert advert);
        void UpdateAdvert(Advert advert);
        List<Advert> GetAllAdvertsWithEr();
        List<Advert> GetAllAdvertsWithErForAdmin();
        List<Advert> GetSearchedAdverts(Advert advert);
        List<Advert> GetAllAdvertsByEmployerID(int id);
        List<Advert> GetAllAdvertsByEmployeeID(int id);
    }
}
