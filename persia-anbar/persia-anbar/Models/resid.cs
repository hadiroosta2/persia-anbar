using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persia_anbar
{
    class resid
    {
        dataBaseContex db ;
        public resid()
        {
            db = new dataBaseContex();
        }
        public int ID { get; set; }
        public string SerialNumber 
        {
            get
            {
                return db.resids.Select(p => p.SerialNumber).DefaultIfEmpty("0").Max();
               
            }
            set { ;}
        }
        public person Person { get; set; }
        public user User { get; set; }
        public DateTime Date 
        {
            get {return DateTime.Now ;}
            set { ;}
        }
        public virtual ICollection<good> Goods { get; set; }
        public factorType Type { get; set; }
        public string Refrence { get; set; }
        public string Description { get; set; }
        public void Save(ResidFrm view)
        {
            this.SerialNumber = view.Number;
            person p = new person();
            this.Person = p.Find(view.Customer);
            this.Date = view.Date;
            this.Refrence = view.Refrence;
            this.Description = view.Description;
            this.Type = factorType.resid;
            this.User.Name = view.Name;
            good g = new good();
            unit u = new unit();
            for (int i = 0; i < view.Goods.Count; i++)
            {
                g.Name = view.Goods[i].Name;
                g.Price = view.Goods[i].Price;
                g.Anbar.Name = view.Goods[i].Anbar.Name;
                g.Unit = view.Goods[i].Unit;
                g.Description = view.Goods[i].Description;
                this.Goods.Add(g);
            }
            db.resids.Add(this);
            p = null;
            g = null;
            u = null;
        }

    }

   
}
