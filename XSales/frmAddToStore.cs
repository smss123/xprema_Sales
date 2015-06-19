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
    public partial class frmAddToStore : Form
    {
        public frmAddToStore()
        {
            InitializeComponent();
        }
        DataBase data = new DataBase();
        private void frmAddToStore_Load(object sender, EventArgs e)
        {
            try
            {
                itemIDRadMultiColumnComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;
                this.Cursor = Cursors.WaitCursor;
                data.db = data.GetContext();

               // itemCategoryBindingSource.DataSource = data.db.ItemCategories;
                itemBindingSource.DataSource = data.db.Items;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                this.Cursor = Cursors.Default;
               // RadMessageBox.ThemeName = itemRadGridView.ThemeName;
                RadMessageBox.Show("خطأ في تحميل البيانات", "", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private int _counter = 0;
        private void itemBarCodeRadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Store str = new Store()
                {
                    DateOfImport = dateOfImportDateTimePicker.Value,
                    ExpiredDate = expiredDateDateTimePicker.Value,
                    ItemID = int.Parse( itemIDRadMultiColumnComboBox.SelectedValue.ToString() ),
                    ItemBarCode = itemBarCodeRadTextBox.Text,
                    Qty = 1,
                   
                };
               
                data.db.Stores.InsertOnSubmit(str);
                data.db.SubmitChanges();
                 
                storeBindingSource.DataSource = data.db.Stores.Where(p=>p.ItemID== int.Parse( itemIDRadMultiColumnComboBox.SelectedValue.ToString() ));
                _counter++;
                lblCount.Text = _counter.ToString();
                itemBarCodeRadTextBox.Text = "";
                itemBarCodeRadTextBox.Focus();
            }
        }

        private void itemIDRadMultiColumnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _counter = 0;
         //  if(itemIDRadMultiColumnComboBox.SelectedIndex != -1)
            //itemBarCodeRadTextBox.Enabled = true;
        }

        private void storeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Validate();
                storeBindingSource.EndEdit();
                data.db.SubmitChanges();
                this.Cursor = Cursors.Default;
                RadMessageBox.Show("تم حفظ البيانات", "", MessageBoxButtons.OK, RadMessageIcon.Info);

            }
            catch (Exception)
            {
                Cursor = Cursors.Default;
               // RadMessageBox.ThemeName = itemCategoryRadGridView.ThemeName;
                RadMessageBox.Show("خطأ في تحميل البيانات", "", MessageBoxButtons.OK, RadMessageIcon.Error);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q =
                data.db.Stores.Where(
                    p =>
                        p.ItemID == int.Parse(itemIDRadMultiColumnComboBox.SelectedValue.ToString()) &&
                        p.DateOfImport.Value.Year == DateTime.Now.Year
                        && p.DateOfImport.Value.Month == DateTime.Now.Month &&
                        p.DateOfImport.Value.Day == DateTime.Now.Day

                    ).ToList();
            if (q.Count!=0)
            {
                data.db.StoreHistories.InsertOnSubmit(new StoreHistory()
                {
                    DateOfProcess = q[0].DateOfImport,
                    ItemID = q[0].ItemID,
                    Qty = q.Sum(p => p.Qty)
                }); 
                data.db.SubmitChanges();
                itemIDRadMultiColumnComboBox.SelectedIndex = -1;
               // itemBarCodeRadTextBox.Enabled = false;
                RadMessageBox.Show("تم التهيئة لادخال صنف جديد");
            }
        }
    }
}
