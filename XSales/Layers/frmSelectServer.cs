using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XSales.Layers
{
    public partial class frmSelectServer : Form
    {
        public frmSelectServer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {               
           // Data Source=SEZER\SQLEXPRESS;Initial Catalog=xpremaSales;Integrated Security=True
            var str = @"Data Source="+textBox1.Text+";Integrated Security=True;   ";
            dbDataContext db = new dbDataContext(str);
            if (!db.DatabaseExists())
            {
                db.CreateDatabase();
                str = str + "Initial Catalog=xpremaSales;";
               // Properties.Settings.Default["xpremaSalesConnectionString"] = str;
                Properties.Settings.Default.constr = str;
                Properties.Settings.Default.Save();
                MessageBox.Show(@"تم الربط بنجاح");
            }
            else
            {
                str = str + "Initial Catalog=xpremaSales;";
                Properties.Settings.Default.constr = str;
                Properties.Settings.Default.Save();
                MessageBox.Show(@"تم الربط بنجاح");

            }
        }
    }
}
