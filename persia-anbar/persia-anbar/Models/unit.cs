using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persia_anbar
{
  public  class unit:generic
    {
        public unit()
        {

        }
        public decimal Amount { get; set; }
        public virtual good Good { get; set; }
    }
}
