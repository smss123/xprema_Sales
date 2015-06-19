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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
          
        }

        DataBase data = new DataBase();
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            try
            {
               // itemIDRadMultiColumnComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;
                this.Cursor = Cursors.WaitCursor;
                data.db = data.GetContext();

                // itemCategoryBindingSource.DataSource = data.db.ItemCategories;
                itemBindingSource.DataSource = data.db.Items;
                customerBindingSource.DataSource = data.db.Customers;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                this.Cursor = Cursors.Default;
                // RadMessageBox.ThemeName = itemRadGridView.ThemeName;
                RadMessageBox.Show("خطأ في تحميل البيانات", "", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Validate();
                customerQDetailsBindingSource.EndEdit();
                customerQotaionsBindingSource.EndEdit();
                customerBindingSource.EndEdit();
                data.db.SubmitChanges();
                this.Cursor = Cursors.Default;
                RadMessageBox.Show("تم حفظ البيانات", "", MessageBoxButtons.OK, RadMessageIcon.Info);

            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
                RadMessageBox.ThemeName = customerRadGridView.ThemeName;
                RadMessageBox.Show("خطأ في تحميل البيانات", "", MessageBoxButtons.OK, RadMessageIcon.Error);


            }
        }

        private void MasterTemplate_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
           
        }
    }
}
