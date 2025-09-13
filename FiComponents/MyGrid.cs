using System.Windows;
using System.Windows.Controls;

namespace OrakUtilWpf.FiComponents
{
  public class MyGrid : Grid
  {
    public string myCustomTag
    {
      get { return (string)GetValue(myCustomTagProperty); }
      set { SetValue(myCustomTagProperty, value); }
    }

    public static readonly DependencyProperty myCustomTagProperty =
      DependencyProperty.Register(
        nameof(myCustomTag),
        typeof(string),
        typeof(MyGrid),
        new PropertyMetadata(null));
  }
}