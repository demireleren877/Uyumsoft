using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAdvertDal: IEntityRepository<Advert>
    {
        List<Advert> GetAllWithEr(Expression<Func<Advert, bool>> filter = null);
        List<Advert> GetAllWithErForAdmin(Expression<Func<Advert, bool>> filter = null);
        List<Advert> GetSearchedAdverts(Advert advert,Expression<Func<Advert, bool>> filter = null);
        List<Advert> GetByIdWithER(int id,Expression<Func<Advert, bool>> filter = null);
        List<Advert> GetAllAdvertsByEmployerID(int id,Expression<Func<Advert, bool>> filter = null);
        List<Advert> GetAllAdvertsByEmployeeID(int id,Expression<Func<Advert, bool>> filter = null);
    }
}
