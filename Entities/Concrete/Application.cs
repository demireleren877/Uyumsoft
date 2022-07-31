using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Application
    {
        [Key]
        public int ApplicationID { get; set; }
        public int EmployeeID { get; set; }
        public int AdvertID { get; set; }
        public Advert Advert { get; set; }
        public Employee Employee{ get; set; }
    }
}
