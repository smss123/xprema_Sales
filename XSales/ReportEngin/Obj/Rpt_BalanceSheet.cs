using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using XSales.Layers;

namespace XSales.ReportEngin.Obj
{
    public class Rpt_BalanceSheet
    {

        public int id { get; set; }
        public string  Account { get; set; }
        public int Type { get; set; }
        public double Amount { get; set; }

        DataBase db = new DataBase();
        public void ShowBalanceSheet(DateTime frm, DateTime to)
        {
            db.db = db.GetContext();
            var q = (from i in db.db.ExpenssesDetails
                     where i.DateOf >= frm && i.DateOf <= to

                     select i).ToList();

            List<Rpt_BalanceSheet> ls = new List<Rpt_BalanceSheet>();

            foreach (var item in q)
            {
                var amount = db.db.ExpenssesDetails.Where(p => p.DateOf == item.DateOf).Sum(p => p.Amount.Value);
                if (item.DateOf != null)
                    ls.Add(new Rpt_BalanceSheet()
                    {
                        Amount = double.Parse("-"+ amount.ToString(CultureInfo.CurrentCulture)),
                        Account = item.Expenss.ExpensessName,
                    });
            }

            var qx = (from i in db.db.Bills
                     where i.BillDate >= frm && i.BillDate <= to
                    
                     select i).ToList();

            

            foreach (var item in qx)
            {
                var amount = db.db.Bills.Where(p => p.BillDate == item.BillDate).Sum(p => p.BillAmunt.Value);
                if (item.BillDate != null)
                    ls.Add(new Rpt_BalanceSheet()
                    {
                        Amount = amount,
                        Account = "ايرادات تاريخ/"+ item.BillDate.Value .ToShortDateString()
                    });
            }
            // XSales.ReportEngin.Sheet.RptSaleBetween2Date.rdlc
            frmviewer frmviewer = new frmviewer();
            ReportDataSource rd = new ReportDataSource { Name = "DataSet1", Value = ls };
            frmviewer.reportViewer1.LocalReport.DataSources.Clear();
            frmviewer.reportViewer1.LocalReport.DataSources.Add(rd);
            frmviewer.reportViewer1.LocalReport.ReportEmbeddedResource = "XSales.ReportEngin.Sheet.Rpt_BalanceSheet.rdlc";
            frmviewer.ShowDialog();
        }

    }
}
