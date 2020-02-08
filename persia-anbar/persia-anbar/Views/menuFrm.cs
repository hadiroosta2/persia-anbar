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
        menuController ctrl;
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
            ctrl = new menuController(this);
            this.setLocation();
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
            ctrl.showSerial();
        }
        public void showPerson()
        {
            ctrl.showPerson();
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        public DataGridView dgv
        {
            get{ return dataGridView1;}
            set { ;}
        }
    }
}
