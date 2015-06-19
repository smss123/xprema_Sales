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
    public partial class frmExpensses : Form
    {
        public frmExpensses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rpt_Expensses frm = new Rpt_Expensses();
            frm.ExpenssesByCount(dtfrm.Value,dtTo.Value);
        }

        private void frmExpensses_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rpt_Expensses frm = new Rpt_Expensses();
            frm.ExpenssesDetails(dt_frm.Value, dt_to.Value);
        }
    }
}
