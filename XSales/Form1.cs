using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XSales.ReportEngin.Obj;

namespace XSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Rpt_Sales frm = new Rpt_Sales();
            frm.GetSalesBetween2Date(dateTimePicker1.Value,dateTimePicker2.Value);
        }
    }
}
