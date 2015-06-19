using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSales.Layers
{
  public  class DataBase   :BaseMyObj
    {
      public dbDataContext db = new dbDataContext();

      public  dbDataContext GetContext()
      {
          return new dbDataContext(Properties.Settings.Default.constr);
      }
    }
}
