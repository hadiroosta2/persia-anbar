using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persia_anbar
{
    class menuController
    {
        menu model;
        menuFrm view;
        public menuController(menuFrm view)
        {
            this.view = view;
            model = new menu();
        }
        public void showSerial()
        {
            model.showSerial(view);
        }
        public void showPerson()
        {
            model.showPerson(view);
        }
    }
}
