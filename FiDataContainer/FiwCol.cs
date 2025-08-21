using OrakUtilWpf.FiComponents;
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

    public FiTextBox txbCol { get; set; }

    public bool? boHiddenFormElem { get; set; }

    /**
    * Form Componentlerde alanın değeri
    */
    public object refValue { get; set; }


    // Getters and Setters

    public TextBlock GenLblCompAsTxbl()
    {
      if (lblCol != null) return lblCol;

      lblCol = new TextBlock();
      lblCol.Text = refFiCol.ofcTxHeader;
      return lblCol;
    }
    public FiTextBox GenTxbCol(FiKeybean fkbItem)
    {
      if(txbCol != null) return null;
      txbCol = new FiTextBox();
      if (fkbItem != null)
      {
        txbCol.Text = fkbItem.GetFieldAsString(refFiCol);;
      }
      return txbCol;
    }

    public FiwCol BuiBoHiddenFormElem(bool prhiddenFormElement)
    {
      this.boHiddenFormElem = prhiddenFormElement;
      return this;
    }
  }
}