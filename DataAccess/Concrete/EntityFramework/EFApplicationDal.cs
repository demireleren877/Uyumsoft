using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFApplicationDal : EFEntityRepositoryBase<Application, Context>, IApplicationDal
    {
        public List<Application> GetAllWithEr(int id,int employerid,Expression<Func<Application, bool>> filter = null)
        {
            using (var context = new Context())
            {
                return context.Applications.Where(x => x.AdvertID == id && x.Advert.EmployerID ==employerid ).Include(x => x.Employee).ToList();
            }
        }
    }
}
