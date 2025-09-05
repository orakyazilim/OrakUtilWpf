using System.Windows.Controls;

namespace OrakUtilWpf.FiComponents
{
  public class FiCheckBox : CheckBox, IFiWpfComp
  {
    public FiCheckBox()
    {

    }
    public string GetFiTxValue()
    {
      return base.IsChecked.ToString();
    }
    public object GetFiObjValue()
    {
      return base.IsChecked;
    }


  }
}