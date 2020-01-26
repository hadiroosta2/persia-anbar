using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persia_anbar
{
    class good
    {
        public good()
        {

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<unit> Unit { get; set; }
    }
}
