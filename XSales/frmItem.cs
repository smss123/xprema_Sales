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
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }

        DataBase data = new DataBase();
        private void frmItem_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                data.db = data.GetContext();

                itemCategoryBindingSource.DataSource = data.db.ItemCategories;
                itemBindingSource.DataSource = data.db.Items;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                this.Cursor = Cursors.Default;
                RadMessageBox.ThemeName = itemRadGridView.ThemeName;
                RadMessageBox.Show("خطأ في تحميل البيانات", "", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Validate();
                itemCategoryBindingSource.EndEdit();
                itemBindingSource.EndEdit();
                data.db.SubmitChanges();
                this.Cursor = Cursors.Default;
                RadMessageBox.Show("تم حفظ البيانات", "", MessageBoxButtons.OK, RadMessageIcon.Info);

            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
                RadMessageBox.ThemeName = itemRadGridView.ThemeName;
                RadMessageBox.Show("خطأ في تحميل البيانات", "", MessageBoxButtons.OK, RadMessageIcon.Error);


            }
        }
    }
}
