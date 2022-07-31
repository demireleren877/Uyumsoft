using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Advert
    {
        [Key]
        public int AdvertID { get; set; }
        public int EmployerID { get; set; }
        public int SectorID { get; set; }
        public int OnlineHybridID { get; set; }
        public int WayOfWorkID { get; set; }
        public int CityID { get; set; }
        public int CompetenceID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Salary { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsApproved { get; set; }
        public Employer Employer { get; set; }
        public Sector Sector { get; set; }
        public OnlineOrHybrid OnlineOrHybrid { get; set; }
        public WayOfWork WayOfWork { get; set; }
        public City City { get; set; }
        public Competence Competence { get; set; }
        public List<Application> Applications { get; set; }
        public int OnlineOrHybridOnlineHybridID{ get; set; }


    }
}
