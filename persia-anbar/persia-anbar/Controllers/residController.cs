using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persia_anbar
{
    class residController
    {
        resid model;
        ResidFrm view;
        public residController(ResidFrm residform)
        {
            view = residform;
        }
        public void Show()
        {

            MessageBox.Show(view.Refrence);
        }
        public void Update()
        {
            model = new resid();
            view.Number = model.SerialNumber;
            view.Date = model.Date;
            view.Refrence = model.Refrence;
            view.Description = model.Description;
            if (model.Goods.Count > 0)
            {
                for (int i = 0; i < model.Goods.Count; i++)
                {

                }
            }
            
        }
        public void Save()
        {
            model.Save(view);  
        }
    }
}
