using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using XSales.Layers;

namespace XSales
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        private double Amount = 0;
        private int currnetBillID = 0;
        private void itemBarCodeRadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                try
                {
                    var q = db.db.Stores.First(p => p.ItemBarCode == itemBarCodeRadTextBox.Text);
                    Amount += float.Parse(q.Item.ItemPrice);
                    if (q.ExpiredDate != null)
                        storesDataGridViewX.Rows.Add(new object[]
                    {  q.ID,
                        q.Item.ItemName + @"\" + q.Item.ItemCategory.CtegoryName,
                        q.Item.ItemPrice,
                        q.Qty,
                        q.ExpiredDate.Value.ToShortDateString()
                    });
                    billAmuntLabel1.Text = Amount.ToString(CultureInfo.CurrentCulture);
                    itemBarCodeRadTextBox.Text = "";
                    itemBarCodeRadTextBox.Focus();
                }
                catch (Exception)
                {

                    RadMessageBox.Show("الصنف غير موجود");
                }
               
            }
            if (e.KeyCode==Keys.ShiftKey)
            {
                if (MessageBox.Show(@"هل تريد طباعه الفاتورة؟","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {

                    Bill bl = new Bill()
                    {
                        BillAmunt = double.Parse(billAmuntLabel1.Text ),
                        BillDate = DateTime.Now,
                        UserID = 1,
                       
                    };

                    foreach (DataGridViewRow item in storesDataGridViewX.Rows)
                    {
                        if (item!=null)
                        {
                            var storId = int.Parse(item.Cells[0].Value.ToString());
                            var q = db.db.Stores.First(p => p.ID == storId);
                            db.db.Stores.DeleteOnSubmit(q);
                            bl.BillDetails.Add(new BillDetail()
                            {
                                ItemID = q.Item.ID,
                                Qty = q.Qty,
                                Status = "0",

                            });

                        }
                     

                    }
                    db.db.Bills.InsertOnSubmit(bl);
                    db.db.SubmitChanges();
                    currnetBillID = bl.ID;
                    MessageBox.Show(@"تم الحفظ");
                    PrintInvoice();
                    storesDataGridViewX.Rows.Clear();
                    Amount = 0;
                    billAmuntLabel1.Text = Amount.ToString(CultureInfo.CurrentCulture);
                    itemBarCodeRadTextBox.Focus();


                }
            }
        }

        private void frmSales_KeyDown(object sender, KeyEventArgs e)
        {
            BaseMyObj cmd = new BaseMyObj();
           
           // MessageBox.Show(e.KeyCode.ToString());
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            db.db = db.GetContext();
            userIDLabel1.Text = HelperCommand.CurrnetUser.FullName;
        }


        private void PrintInvoice()
        {
            PrintDialog print = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            print.Document = printDocument;
            printDocument.PrintPage += printDocument_PrintPage;
            if (print.ShowDialog()==DialogResult.OK)
            {
              printDocument.Print();  
            }
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            System.Drawing.Font font = new Font("Courier New", 12);
            float fonthight = font.GetHeight();
            const int startX = 10;
            const int startY = 10;
            int offset = 50;
            graphics.DrawString("Welcome", new Font("Courier New", 16), new SolidBrush(Color.Black), startX, startY);
            //graphics.DrawString("*************", new Font("Times New Roman", 16), new SolidBrush(Color.Black), startX, startY+13);

            //string pro = "Item " + "--------------" + "المبلغ";
            //graphics.DrawString(pro, new Font("Times New Roman", 12), new SolidBrush(Color.Black), startX, startY + 13);
            graphics.DrawString("=====", new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + 20);
            var q = db.db.Bills.First(p => p.ID == currnetBillID);
            foreach (var item in q.BillDetails)
            {
                string productdescription = (item.Item.ItemName).PadLeft(30);

                string productTotal = string.Format("{0}",item.Item.ItemPrice).PadRight(50);
                string productLine = productdescription + "-" + productTotal;
                string line = "\n--\n";
                graphics.DrawString(productLine,font,new SolidBrush(Color.Black),startX,startY+offset );
                offset = offset + (int)fonthight + 5;
                

            }
            offset = offset + 20;
            if (q.BillAmunt != null)
            {
                var str = "Total is :".PadLeft(30) + string.Format("{0}", q.BillAmunt.Value.ToString(CultureInfo.CurrentCulture));
                graphics.DrawString(str,font,new SolidBrush(Color.Black),startX,startY+offset );
            }
            offset = offset + (startY*2);

            graphics.DrawString("====", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (startY * 2);
            // ReSharper disable once InconsistentNaming
            var Item = "Time Is " + DateTime.Now.ToString(CultureInfo.CurrentCulture) + "\n The User Is "+HelperCommand.CurrnetUser.FullName;
            graphics.DrawString(Item, font, new SolidBrush(Color.Black), startX, startY + offset);



        }
    }
}
