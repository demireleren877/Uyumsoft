using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModel
{
    public class IndexVM
    {
        public List<Employee> Employees { get; set; }
        public List<Advert> Adverts { get; set; }
        public List<City> Cities { get; set; }
        public List<WayOfWork> WayOfWorks { get; set; }
        public List<Sector> Sectors { get; set; }
        public List<OnlineOrHybrid> OnlineOrHybrids { get; set; }
        public List<Competence> Competences { get; set; }
    }
}
