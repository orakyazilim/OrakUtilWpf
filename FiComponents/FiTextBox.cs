using System.Windows.Controls;

namespace OrakUtilWpf.FiComponents
{
  public class FiTextBox : TextBox, IFiWpfComp
  {
  public FiTextBox()
  {

  }
  public string GetFiTxValue()
  {
    return base.Text;
  }
  public object GetFiObjValue()
  {
    return null;
  }
  }
}