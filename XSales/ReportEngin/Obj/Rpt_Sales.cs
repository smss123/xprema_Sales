using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using XSales.Layers;

namespace XSales.ReportEngin.Obj
{
  public  class Rpt_Sales
    {
     public DateTime dateofsale { get; set; }
      public double TotalAmount { get; set; }

      DataBase db = new DataBase();
      public void GetSalesBetween2Date(DateTime frm, DateTime to)
      {
          db.db = db.GetContext();
          var q = (from i in db.db.Bills
              where i.BillDate >= frm && i.BillDate <= to
              select i).ToList();

          List<Rpt_Sales> ls = new List<Rpt_Sales>();

          foreach (var item in q)
          {
              var amount = db.db.Bills.Where(p => p.BillDate == item.BillDate).Sum(p => p.BillAmunt.Value);
              if (item.BillDate != null)
                  ls.Add(new Rpt_Sales()
                  {
                      TotalAmount = amount,
                      dateofsale = item.BillDate.Value
                  });
          }
          //XSales.ReportEngin.Sheet.RptSaleBetween2Date.rdlc
          frmviewer frmviewer = new frmviewer();
          ReportDataSource rd = new ReportDataSource {Name = "DataSet1", Value = ls};
          frmviewer.reportViewer1.LocalReport.DataSources.Clear();
          frmviewer.reportViewer1.LocalReport.DataSources.Add(rd);
          frmviewer.reportViewer1.LocalReport.ReportEmbeddedResource = "XSales.ReportEngin.Sheet.RptSaleBetween2Date.rdlc";
          frmviewer.ShowDialog();
      }

      public void GetSalesBetween2Date(DateTime frm, DateTime to  , int userId)
      {
          db.db = db.GetContext();
          var q = (from i in db.db.Bills
                   where i.BillDate >= frm && i.BillDate <= to
                   & i.UserID == userId
                   select i).ToList();

          List<Rpt_Sales> ls = new List<Rpt_Sales>();

          foreach (var item in q)
          {
              var amount = db.db.Bills.Where(p => p.BillDate == item.BillDate).Sum(p => p.BillAmunt.Value);
              if (item.BillDate != null)
                  ls.Add(new Rpt_Sales()
                  {
                      TotalAmount = amount,
                      dateofsale = item.BillDate.Value
                  });
          }
          //XSales.ReportEngin.Sheet.RptSaleBetween2Date.rdlc
          frmviewer frmviewer = new frmviewer();
          ReportDataSource rd = new ReportDataSource { Name = "DataSet1", Value = ls };
          frmviewer.reportViewer1.LocalReport.DataSources.Clear();
          frmviewer.reportViewer1.LocalReport.DataSources.Add(rd);
          frmviewer.reportViewer1.LocalReport.ReportEmbeddedResource = "XSales.ReportEngin.Sheet.RptSaleBetween2Date.rdlc";
          frmviewer.ShowDialog();
      }
    }
}
