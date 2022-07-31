using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Employer
    {
        [Key]
        public int EmployerID { get; set; }
        public int TaxNumber { get; set; }
        public string Addresses { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string UserKind { get; set; }
        public List<Advert> Adverts { get; set; }
    }
}
