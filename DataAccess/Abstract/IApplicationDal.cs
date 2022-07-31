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
    public interface IApplicationDal:IEntityRepository<Application>
    {
        List<Application> GetAllWithEr(int id , int employerid,Expression<Func<Application, bool>> filter = null);
    }
}
