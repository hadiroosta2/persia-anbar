using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace persia_anbar
{
    public partial class MainFrm : Form
    {
        TabControl tc;
        public MainFrm()
        {
            InitializeComponent();
        }
        private void add(Form frm, string name)
        {
            tc.Visible = true;
            //چون تنها کنترل داخل پنل یک تب کنترلر است پس وقتی تعداد کنترل های پنل 1 بزرگتر از صفر باشد یعنی 
            // تب کنترلر در پنل وجود دارد و باید تب پبج را اضافه کنیم 
            if (panel1.Controls.Count > 0)
            {
                TabPage tp = new TabPage(name);

                tc.TabPages.Add(tp);
                frm.TopLevel = false;
                tp.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
                tc.SelectedTab = tp;
            }
            // در این حالت اول تب کنترلر را اضافه میکنیم 
            else
            {

                panel1.Controls.Add(tc);
                tc.Dock = DockStyle.Fill;
                TabPage tp = new TabPage(name);
                tc.TabPages.Add(tp);
                frm.TopLevel = false;
                tp.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
                tc.SelectedTab = tp;
            }



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            tc = new TabControl();
        }

        private void رسیدانبارToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            ResidFrm f2 = new ResidFrm();
            f2.FormClosing += f2_FormClosing;
            add(f2, " رسید انبار " );
        }
        void f2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //   tc.TabPages.RemoveByKey("رسید ورود کالا");
            int i = tc.SelectedIndex;
            tc.TabPages.RemoveAt(i);
            if (tc.TabCount == 0)
                tc.Hide();
            else
            {
                if (i > 0)
                {
                    tc.SelectedIndex = i - 1;

                }
                else
                    tc.SelectedIndex = 0;

            }



        }
    }
}
