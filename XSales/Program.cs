using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XSales.Layers;

namespace XSales
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.constr))
            {

                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    
                 frmSelectServer frm = new frmSelectServer();
                    frm.ShowDialog();
                }
            }


            Application.Run(new frmLogin());
        }
    }
}
