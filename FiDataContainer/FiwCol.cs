using OrakYazilimLib.DbGeneric;
using OrakYazilimLib.Util.core;
using System.Windows.Controls;

namespace OrakUtilWpf.FiDataContainer
{
  /**
   * FiWpfCol
   */
  public class FiwCol
  {
    public FiCol refFiCol { get; set; }

    public TextBlock lblCol { get; set; }

    public TextBox txbCol { get; set; }

    public TextBlock GetLblCol()
    {
      if (lblCol != null) return lblCol;

      lblCol = new TextBlock();
      lblCol.Text = refFiCol.ofcTxHeader;
      return lblCol;
    }
    public TextBox GetTxbCol(FiKeybean fkbItem)
    {
      if(txbCol != null) return txbCol;
      txbCol = new TextBox();
      if (fkbItem != null)
      {
        txbCol.Text = fkbItem.GetFieldAsString(refFiCol);;
      }
      return txbCol;
    }

  }
}