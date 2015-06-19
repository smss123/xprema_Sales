using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using XSales.Layers;

namespace XSales
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
         DataBase db = new DataBase();
        private void buttonX1_Click(object sender, EventArgs e)
        {

            db.db = db.GetContext();
            var q = db.db.Users.Where(p => p.pwd == txtPassword.Text).ToList();
            if (q.Count!=0)
            {
                frmMain frmMain = new frmMain();
                HelperCommand.CurrnetUser = q[0];
                frmMain.Show();
                Hide();
            }
            else
            {
                RadMessageBox.Show("البيانات الدخول غير صحيحة");
            }

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show("هل تريد الخروج؟", "", MessageBoxButtons.YesNo, RadMessageIcon.Question) ==
                DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
