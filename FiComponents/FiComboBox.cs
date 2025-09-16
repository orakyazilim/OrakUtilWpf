using OrakYazilimLib.FiContainer;
using System.Windows.Controls;

namespace OrakUtilWpf.FiComponents
{
  public class FiComboBox : ComboBox, IFiWpfComp
  {
    public FiComboBox()
    {

    }
    public string GetFiTxValue()
    {
      if (base.SelectedItem is FiComboItem selectedItem)
      {
        return selectedItem.txKey;
      }
      return null; //base.IsChecked.ToString();
    }
    public object GetFiObjValue()
    {
      if (base.SelectedItem is FiComboItem selectedItem)
      {
        return selectedItem;
      }
      return null; // base.IsChecked;
    }


  }
}