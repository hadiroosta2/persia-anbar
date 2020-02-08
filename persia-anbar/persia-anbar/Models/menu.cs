using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persia_anbar
{
    class menu
    {
        dataBaseContex db;
        public menu()
        {
            db = new dataBaseContex();
        }
        public void showSerial(menuFrm view)
        {
            var serial = db.resids;
            foreach (resid r in serial)
            {
                view.dgv.Rows.Add(1);

            }
            view.ShowDialog();
        }
        public void showPerson(menuFrm view)
        {
            var person = db.persons;
            foreach(person p in person)
            {
                view.dgv.Rows.Add(1);
            }
            view.ShowDialog();
        }
    }
}
