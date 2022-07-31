using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFEmployeeDal : EFEntityRepositoryBase<Employee, Context>, IEmployeeDal
    {
        public List<Employee> GetAllWithCity()
        {
            using(var context = new Context())
            {
                return context.Employees.Include(x=>x.City).ToList();
            }
        }
    }
}
