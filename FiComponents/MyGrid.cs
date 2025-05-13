using System.Windows;
using System.Windows.Controls;

namespace OrakUtilWpf.FiComponents
{
  public class MyGrid : Grid
  {
    public string MyCustomTag
    {
      get { return (string)GetValue(MyCustomTagProperty); }
      set { SetValue(MyCustomTagProperty, value); }
    }

    public static readonly DependencyProperty MyCustomTagProperty =
      DependencyProperty.Register(
        nameof(MyCustomTag),
        typeof(string),
        typeof(MyGrid),
        new PropertyMetadata(null));
  }
}