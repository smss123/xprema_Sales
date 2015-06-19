using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Reporting.WinForms;
using XSales.Layers;

namespace XSales.ReportEngin.Obj
{
   public class Rpt_Expensses
    {

       public int ID { get; set; }
       public string  Expensses { get; set; }
       public double Amount { get; set; }
       public string Description { get; set; }
       public DateTime dateT { get; set; }

       DataBase db = new DataBase();

       public void ExpenssesByCount(DateTime frm, DateTime to)
       {
           db.db = db.GetContext();
           var q = (from i in db.db.ExpenssesDetails
                    where i.DateOf >= frm && i.DateOf <= to
                    
                    select i).ToList();

           List<Rpt_Expensses> ls = new List<Rpt_Expensses>();

           foreach (var item in q)
           {
               var amount = db.db.ExpenssesDetails.Where(p => p.DateOf == item.DateOf).Sum(p => p.Amount.Value);
               if (item.DateOf != null)
                   ls.Add(new Rpt_Expensses()
                   {
                      Amount = amount,
                      Expensses =item.Expenss.ExpensessName,
                      Description = item.Description,
                      ID = item.Expenss.ID
                   });
           }
          // XSales.ReportEngin.Sheet.RptSaleBetween2Date.rdlc
           frmviewer frmviewer = new frmviewer();
            ReportDataSource rd = new ReportDataSource { Name = "DataSet1", Value = ls };
            frmviewer.reportViewer1.LocalReport.DataSources.Clear();
            frmviewer.reportViewer1.LocalReport.DataSources.Add(rd);
            frmviewer.reportViewer1.LocalReport.ReportEmbeddedResource = "XSales.ReportEngin.Sheet.RptExpensses_ByCount.rdlc";
           frmviewer.ShowDialog();
       }

       public void ExpenssesDetails(DateTime frm, DateTime to)
       {
           db.db = db.GetContext();
           var q = (from i in db.db.ExpenssesDetails
                    where i.DateOf >= frm && i.DateOf <= to

                    select i).ToList();

           List<Rpt_Expensses> ls = new List<Rpt_Expensses>();

           foreach (var item in q)
           {
               var amount = db.db.ExpenssesDetails.Where(p => p.DateOf == item.DateOf).Sum(p => p.Amount.Value);
               if (item.DateOf != null)
                   ls.Add(new Rpt_Expensses()
                   {
                       Amount = amount,
                       Expensses = item.Expenss.ExpensessName,
                       Description = item.Description,
                       ID = item.Expenss.ID   ,
                       dateT = item.DateOf.Value
                   });
           }
           // XSales.ReportEngin.Sheet.RptSaleBetween2Date.rdlc
           frmviewer frmviewer = new frmviewer();
           ReportDataSource rd = new ReportDataSource { Name = "DataSet1", Value = ls };
           frmviewer.reportViewer1.LocalReport.DataSources.Clear();
           frmviewer.reportViewer1.LocalReport.DataSources.Add(rd);
           frmviewer.reportViewer1.LocalReport.ReportEmbeddedResource = "XSales.ReportEngin.Sheet.Rp_ExpenssesDetails.rdlc";
           frmviewer.ShowDialog();
       }
    }
}
