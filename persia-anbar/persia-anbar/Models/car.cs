using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persia_anbar
{
    class car:generic
    {
        public car()
        {

        }
        public string CarNumber { get; set; }
        public virtual person Person { get; set; }
    }
}
