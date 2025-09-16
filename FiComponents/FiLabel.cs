using System.Windows.Controls;

namespace OrakUtilWpf.FiComponents
{
  public class FiLabel : TextBlock, IFiWpfComp
  {

  public FiLabel()
  {

  }
  public FiLabel(string txLabel)
  {
    base.Text = txLabel;
  }

  public string GetFiTxValue()
  {
    return base.Text;
  }
  public object GetFiObjValue()
  {
    return null;
  }



  } // end class
}