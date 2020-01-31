using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persia_anbar
{
  public  class good : generic
    {

        public good()
        {

        }
        public bool Active { get; set; }
        public decimal Price { get; set; }
        public anbar Anbar { get; set; }
        public virtual ICollection<unit> Unit { get; set; }
        public string Description { get; set; }
       
    }
}
