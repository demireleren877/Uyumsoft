using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-DRT5BB2\SQLEXPRESS;Database=Uyumsoft-1;Trusted_Connection=true");
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Competence> Competences { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<OnlineOrHybrid> OnlineOrHybrids { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<WayOfWork> WayOfWorks { get; set; }
        public DbSet<Application> Applications { get; set; }
    }
}
