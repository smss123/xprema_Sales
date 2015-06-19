using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XSales.Layers;
using XSales.ReportEngin.Obj;

namespace XSales.ReportEngin.Options
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rpt_Sales frm = new Rpt_Sales();
            frm.GetSalesBetween2Date(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        DataBase db = new DataBase();
        private void frmSales_Load(object sender, EventArgs e)
        {
            db.db = db.GetContext();
            UsercomboBox.DisplayMember = "FullName";
            UsercomboBox.ValueMember = "ID";
            UsercomboBox.DataSource = db.db.Users.ToList();
        }

        private void superTabControlPanel2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Rpt_Sales frm = new Rpt_Sales();
            frm.GetSalesBetween2Date(dtfrm.Value, dtTo.Value,int.Parse(UsercomboBox.SelectedValue.ToString()));
        }
    }
}
