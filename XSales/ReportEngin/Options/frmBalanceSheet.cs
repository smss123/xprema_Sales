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

namespace XSales.ReportEngin.Options
{
    public partial class frmBalanceSheet : Form
    {
        public frmBalanceSheet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rpt_BalanceSheet cmd = new Rpt_BalanceSheet();
            cmd.ShowBalanceSheet(dt_frm.Value,dt_To.Value);
        }
    }
}
