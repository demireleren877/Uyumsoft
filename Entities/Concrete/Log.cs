using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Log
    {
        [Key]
        public int LogID { get; set; }
        public DateTime Time { get; set; }
        public int AdminID { get; set; }
        public Admin Admin { get; set; }
    }
}
