using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModel
{
    public class Models
    {
        public Advert Advert { get; set; }
        public List<Advert> Adverts { get; set; }
        public Sector Sector { get; set; }
        public WayOfWork WayOfWork { get; set; }
        public OnlineOrHybrid OnlineOrHybrid { get; set; }
        public Competence Competence { get; set; }
        public City City { get; set; }
    }
}
