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
        Header = fiCol.ofcTxHeader,
        Binding = new Binding($"[{fiCol.ofcTxFieldName}]")
      };

      return column;
    }
  }
}