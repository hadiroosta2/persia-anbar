using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persia_anbar
{
    class person:generic
    {
        dataBaseContex db;
        public person()
        {
            db = new dataBaseContex();
        }
        public person Find(string name)
        {
            person p = db.persons.Where(b => b.Name == name).First();
            return p;
        }
        public string Adress { get; set; }
        public bool Active { get; set; }
        public string CodeMelli { get; set; }
        public virtual ICollection<tell> Tell { get; set; }
        public virtual ICollection<car> Car { get; set; }
    }
}
