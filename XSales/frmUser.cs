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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Validate();
                userBindingSource.EndEdit();
                data.db.SubmitChanges();
                this.Cursor = Cursors.Default;
                RadMessageBox.Show("تم حفظ البيانات", "", MessageBoxButtons.OK, RadMessageIcon.Info);

            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
                RadMessageBox.ThemeName = userRadGridView.ThemeName;
                RadMessageBox.Show("خطأ في تحميل البيانات", "", MessageBoxButtons.OK, RadMessageIcon.Error);


            }
        }
        DataBase data = new DataBase();
        private void frmUser_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                data.db = data.GetContext();

                userBindingSource.DataSource = data.db.Users;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                this.Cursor = Cursors.Default;
                RadMessageBox.ThemeName = userRadGridView.ThemeName;
                RadMessageBox.Show("خطأ في تحميل البيانات", "", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }
    }
}
