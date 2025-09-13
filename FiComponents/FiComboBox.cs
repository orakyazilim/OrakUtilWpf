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
      return ""; //base.IsChecked.ToString();
    }
    public object GetFiObjValue()
    {
      return null; // base.IsChecked;
    }


  }
}