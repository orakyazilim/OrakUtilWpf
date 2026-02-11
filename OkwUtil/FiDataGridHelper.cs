using OrakUtilDotNetFrm.DbGeneric;
using OrakYazilimLib.DbGeneric;
using System.Windows.Controls;
using System.Windows.Data;

namespace OrakUtilWpf.FiComponents
{
  public class FiDataGridHelper
  {
    public static DataGridTextColumn GenDataGridCol(FiCol fiCol)
    {

      DataGridTextColumn column = new DataGridTextColumn
      {
        Header = fiCol.fcTxHeader,
        Binding = new Binding($"[{fiCol.fcTxFieldName}]")
      };

      return column;
    }
  }
}