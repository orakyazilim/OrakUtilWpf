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

    public FiLabel lblCol { get; set; }

    public FiTextBox txbCol { get; set; }

    public IFiWpfComp ifwComp { get; set; }

    public bool? boHiddenFormElem { get; set; }

    /**
    * Form Componentlerde alanın değeri
    *
    * hidden elementlerda değer burada tutulur
    */
    public object refValue { get; set; }


    // Getters and Setters

    public FiLabel GenLabel()
    {
      //if (lblCol != null) return lblCol;

      lblCol = new FiLabel();
      lblCol.Text = refFiCol.ofcTxHeader;
      return lblCol;
    }
    public FiTextBox GenTextBox(FiKeybean fkbForm)
    {
      // txbCol önceden üretilmişse onu getirir
      //if(txbCol != null) return txbCol;

      txbCol = new FiTextBox();
      this.ifwComp = txbCol;

      if (fkbForm == null) return txbCol;

      txbCol.Text = fkbForm.GetFieldAsString(refFiCol);
      ;
      return txbCol;
    }

    public FiwCol BuiBoHiddenFormElem(bool prhiddenFormElement)
    {
      this.boHiddenFormElem = prhiddenFormElement;
      return this;
    }
  }
}