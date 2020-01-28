using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persia_anbar
{
    class tell
    {
        public tell()
        {

        }
        public int ID { get; set; }
        public string  Number { get; set; }
        public virtual person Person { get; set; }

    }
}
