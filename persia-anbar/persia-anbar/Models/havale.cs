﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persia_anbar
{
    class havale
    {
        public havale()
        {

        }
        public int ID { get; set; }
        public string SerialNumber { get; set; }
        public person Person { get; set; }
        public user User { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<good> Good { get; set; }
        public factorType Type { get; set; }
        public string Description { get; set; }
    }
}
