﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persia_anbar
{
    class person
    {
        public person()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public bool Active { get; set; }
        public string CodeMelli { get; set; }
        public virtual ICollection<tell> Tell { get; set; }
        public virtual ICollection<car> Car { get; set; }
    }
}
