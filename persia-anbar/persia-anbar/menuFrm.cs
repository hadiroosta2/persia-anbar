using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persia_anbar
{
    public partial class menuFrm : Form
    {
        dataBaseContex db;
        int x = 0;
        int y = 0;
        Control parent = null;
        Control formenu = null;
        public menuFrm(Control Parent, Control Formenu)
        {
            InitializeComponent();
            this.parent = Parent;
            this.formenu = Formenu;
            this.StartPosition = FormStartPosition.Manual;
            db = new dataBaseContex();
        }
        private void setLocation()
        {
            Point p2 = parent.PointToScreen(formenu.Location);
            x = p2.X - this.Width + formenu.Width;
            y = p2.Y + formenu.Height + 2;
            this.Location = new Point(x, y);
            
        }
        public void showSerial()
        {
            this.setLocation();
            
            this.ShowDialog();
        }

    }
}
