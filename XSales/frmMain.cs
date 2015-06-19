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
using XSales.ReportEngin.Options;

namespace XSales
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            slidePanel1.IsOpen = false;
        }

        private void radLiveTileElement2_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.Show();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            frmItem frm = new frmItem();
            frm.Show();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            frmStore frm = new frmStore();
            frm.Show();
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            frmPurshes frm = new frmPurshes();
            frm.Show();
        }

        private void btnExpensses_Click(object sender, EventArgs e)
        {
            frmExpensses frm = new frmExpensses();
            frm.Show();
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            frmAddToStore frm = new frmAddToStore();
            frm.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales frm = new frmSales();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            radPanorama1.Left = (this.ClientSize.Width - radPanorama1.Width) / 2;
            radPanorama1.Top = (this.ClientSize.Height - radPanorama1.Height) / 2;
            this.radPanorama1.AllowDragDrop = true;
            var user = HelperCommand.CurrnetUser;
            if (user!=null)
            {
                if (user.IsCategory != null) btnCategory.Enabled = user.IsCategory.Value;
                if (user.IsItem != null) btnItem.Enabled = user.IsItem.Value;

                if (user.IsStore != null) btnStore.Enabled = user.IsStore.Value;
                if (user.Ispurchase != null) btnpurchase.Enabled = user.Ispurchase.Value;

                if (user.IsSales != null) btnSales.Enabled = user.IsSales.Value;
                if (user.IsExpensses != null) btnExpensses.Enabled = user.IsExpensses.Value;

                if (user.IsGoods != null) btnGoods.Enabled = user.IsGoods.Value;
                if (user.IsSalesBetween2Date != null) btnSalesBetween2Date.Enabled = user.IsSalesBetween2Date.Value;

               

                if (user.IsReportExpensses != null) btnReportExpensses.Enabled = user.IsReportExpensses.Value;
                if (user.IsBalanceSheet != null) btnBalanceSheet.Enabled = user.IsBalanceSheet.Value;
                if (user.IsUser != null) btnUsers.Enabled = user.IsUser.Value;
                lblName.Text = user.FullName;
            }

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            slidePanel1.IsOpen = true;
        }

        private void btnSalesBetween2Date_Click(object sender, EventArgs e)
        {
            ReportEngin.Options.frmSales frm = new ReportEngin.Options.frmSales();
            frm.Show();
        }

        private void btnReportExpensses_Click(object sender, EventArgs e)
        {
            XSales.ReportEngin.Options.frmExpensses frm = new XSales.ReportEngin.Options.frmExpensses();
            frm.Show();
        }

        private void btnBalanceSheet_Click(object sender, EventArgs e)
        {
            frmBalanceSheet frm = new frmBalanceSheet();
            frm.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show("هل تريد الخروج؟", "", MessageBoxButtons.YesNo, RadMessageIcon.Question) ==
               DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
