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
    public partial class frmPurshes : Form
    {
        public frmPurshes()
        {
            InitializeComponent();
        }

        DataBase data = new DataBase();
        private void frmPurshes_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                data.db = data.GetContext();

                purshesBillBindingSource.DataSource = data.db.PurshesBills;
                itemBindingSource.DataSource = data.db.Items;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                this.Cursor = Cursors.Default;
                RadMessageBox.ThemeName = purshesBillRadGridView.ThemeName;
                RadMessageBox.Show("خطأ في تحميل البيانات", "", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void purshesBillBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Validate();
                purshesBillBindingSource.EndEdit();
                pourshesDetailsBindingSource.EndEdit();
                //itemBindingSource.EndEdit();
                data.db.SubmitChanges();
                this.Cursor = Cursors.Default;
                RadMessageBox.Show("تم حفظ البيانات", "", MessageBoxButtons.OK, RadMessageIcon.Info);

            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
                RadMessageBox.ThemeName = purshesBillRadGridView.ThemeName;
                RadMessageBox.Show("خطأ في تحميل البيانات", "", MessageBoxButtons.OK, RadMessageIcon.Error);


            }
        }
    }
}
