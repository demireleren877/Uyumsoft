using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string School { get; set; }
        public string Department { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int CityID { get; set; }
        public string UserKind { get; set; }
        public City City { get; set; }
        public List<Application> Applications { get; set; }
    }
}
