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
    public class EFAdvertDal : EFEntityRepositoryBase<Advert, Context>, IAdvertDal
    {
        public List<Advert> GetAllAdvertsByEmployeeID(int id, Expression<Func<Advert, bool>> filter = null)
        {
            using (var context = new Context())
            {
                var applications = context.Applications.Where(x => x.EmployeeID == id).ToList();
                var values = applications.Select(x => x.AdvertID).ToList();
                return context.Adverts.Where(x =>values.Contains(x.AdvertID)).Include(x => x.City).Include(x => x.OnlineOrHybrid).Include(x => x.WayOfWork).Include(x => x.Employer).Include(x => x.Sector).Include(x => x.Competence).ToList();
            }
        }

        public List<Advert> GetAllAdvertsByEmployerID(int id, Expression<Func<Advert, bool>> filter = null)
        {
            using (var context = new Context())
            {
                return context.Adverts.Where(x => x.EmployerID==id).Include(x => x.City).Include(x => x.OnlineOrHybrid).Include(x => x.WayOfWork).Include(x => x.Employer).Include(x => x.Sector).Include(x => x.Competence).ToList();
            }
        }

        public List<Advert> GetAllWithEr(Expression<Func<Advert, bool>> filter = null)
        {
            using (var context = new Context())
            {
                return context.Adverts.Where(x=>x.IsApproved==true).Include(x => x.City).Include(x=>x.OnlineOrHybrid).Include(x=>x.WayOfWork).Include(x=>x.Employer).Include(x => x.Sector).Include(x => x.Competence).ToList();
            }
        }
        public List<Advert> GetAllWithErForAdmin(Expression<Func<Advert, bool>> filter = null)
        {
            using (var context = new Context())
            {
                return context.Adverts.Include(x => x.City).Include(x => x.OnlineOrHybrid).Include(x => x.WayOfWork).Include(x => x.Employer).Include(x => x.Sector).Include(x => x.Competence).ToList();
            }
        }

        public List<Advert> GetByIdWithER(int id,Expression<Func<Advert, bool>> filter = null)
        {
            using (var context = new Context())
            {
                return context.Adverts.Where(x=>x.AdvertID==id && x.IsApproved==true).Include(x => x.City).Include(x => x.OnlineOrHybrid).Include(x => x.WayOfWork).Include(x => x.Employer).Include(x => x.Sector).Include(x => x.Competence).ToList();
            }
        }
        

        public List<Advert> GetSearchedAdverts(Advert advert,Expression<Func<Advert, bool>> filter = null)
        {
            using (var context = new Context())
            {
                var adverts = context.Adverts.Where(x=>x.IsApproved==true).Include(x => x.City).Include(x => x.OnlineOrHybrid).Include(x => x.WayOfWork).Include(x => x.Employer).Include(x => x.Sector).Include(x => x.Competence).ToList();
                if (advert.WayOfWorkID != 0 || advert.CompetenceID != 0 || advert.CityID != 0 || advert.SectorID != 0)
                {
                    return adverts.Where(
                        x=>x.IsApproved==true && (x.WayOfWorkID == advert.WayOfWorkID || x.CompetenceID == advert.CompetenceID || x.CityID == advert.CityID || x.SectorID == advert.SectorID)
                        ).ToList();
                }
                else
                {
                    return adverts;
                }
            }
        }
    }
}
