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
    public partial class ResidFrm : Form
    {
        residController ctrl;
        public string Number 
        {
            get {return txtNumber.Text ;}
            set {txtNumber.Text=value ;}
        }
        public string Customer
        {
            get {return txtCustomer.Text ;}
            set {txtCustomer.Text=value ;} 
        }
        public DateTime Date 
        {
            get {return Convert.ToDateTime(txtDate.Text) ;}
            set {txtDate.Text= value.ToString() ;}
        }
        public string Refrence
        {
            get {return txtRefrens.Text ;}
            set {txtRefrens.Text=value ;}
        }
        public string Description
        {
            get {return txtDescription.Text ;}
            set {txtDescription.Text=value ;}
        }
        public List<good> Goods 
        {
            get 
            {
                List<good> goodList=new List<good> ();
                good g = new good();
                unit u=new unit ();
                for (int i = 0; i < dgvGoods.Rows.Count; i++)
                {
                    g.Name = dgvGoods.Rows[i].Cells["name"].Value.ToString();
                    g.Anbar.Name = dgvGoods.Rows[i].Cells["name"].Value.ToString();
                    g.Price =Convert.ToDecimal( dgvGoods.Rows[i].Cells["name"].Value);
                    g.Description = dgvGoods.Rows[i].Cells["name"].Value.ToString();
                     for (int j = 1; j < 3; j++)
                       {
                          u.Name = dgvGoods.Rows[i].Cells["uname" + j].ToString();
                          u.Amount = Convert.ToDecimal(dgvGoods.Rows[i].Cells["uamount" + j]);
                          g.Unit.Add(u);
                        }
                   
                }
                return goodList ;
                    
            }
            set { ;} 
        }
        public string User 
        {
            get {return txtUser.Text ;}
            set {txtUser.Text=value ;} 
        }
        public ResidFrm()
        {
            InitializeComponent();
            ctrl = new residController(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ctrl.Save();
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ctrl.Save();
        }

        private void ResidFrm_Load(object sender, EventArgs e)
        {
            dgvGoods.Rows.Add(1);
          //  ctrl.Update();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ctrl.Update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ctrl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataBaseContex db = new dataBaseContex();
            resid r = new resid();
            r.SerialNumber = "1111";
            r.Date = DateTime.Now;
            db.resids.Add(r);
            db.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSerialSearch_Click(object sender, EventArgs e)
        {
            menuFrm m = new menuFrm(panel1, txtNumber);

            m.showSerial();
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {

            menuFrm m = new menuFrm(panel1, txtCustomer);

            m.ShowDialog();
        }
       

    }
}
