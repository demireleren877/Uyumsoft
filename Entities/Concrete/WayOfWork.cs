﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class WayOfWork
    {
        [Key]
        public int WayOfWorkID { get; set; }
        public string Name { get; set; }
        public List<Advert> Adverts { get; set; }
    }
}
