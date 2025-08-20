using OrakUtilWpf.FiDataContainer;
using OrakYazilimLib.Util.core;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace OrakUtilWpf.FiComponents
{
  public class FormGrid
  {

    public Grid gridForm { get; set; }

    public FwcList fwcList { get; set; }

    public FiKeybean fkbForm { get; set; }

    public FormGrid()
    {
      // Yeni Grid nesnesi
      gridForm = new Grid()
      {
        Margin = new Thickness(10),
        Background = Brushes.AliceBlue
        ,HorizontalAlignment = HorizontalAlignment.Stretch

      };

      // Satır ve sütunlar ekle
      gridForm.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
      //gridForm.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
      gridForm.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto });
      gridForm.ColumnDefinitions.Add(new ColumnDefinition() { MinWidth = 200.0d  });
      // gridForm.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
      // gridForm.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(3, GridUnitType.Star) });

    }

    public void GenerateComps()
    {
      if (this.fwcList == null)
      {
        return;
      }

      foreach (FiwCol fclFormElement in fwcList)
      {

        if(FiBool.IsTrue(fclFormElement.boHiddenFormElem))
        {
          fclFormElement.refValue = fkbForm.GetFieldAsObject(fclFormElement.refFiCol);
          continue;
        }

        // Yeni bir RowDefinition tanımlayın
        RowDefinition newRow = new RowDefinition();
        newRow.Height = GridLength.Auto; // Satır yüksekliğini ayarlayın (Auto, *, pixel gibi)

        // Grid'in RowDefinitions koleksiyonuna ekleyin
        this.gridForm.RowDefinitions.Add(newRow);

        int rowDefinitionsCount = this.gridForm.RowDefinitions.Count - 1;
        // Component Grid'e yerleştirme
        TextBlock lbtField = fclFormElement.GetLblCol();
        Grid.SetRow(lbtField, rowDefinitionsCount); // Son eklenen satıra 1. içerik
        Grid.SetColumn(lbtField, 0); // İlk sütuna

        TextBox txbField = fclFormElement.GetTxbCol(fkbForm);
        txbField.HorizontalAlignment = HorizontalAlignment.Stretch;
        Grid.SetRow(txbField, rowDefinitionsCount); // Son eklenen satıra 1. içerik
        Grid.SetColumn(txbField, 1); // İlk sütuna

        // Elemanları Grid'e ekle
        gridForm.Children.Add(lbtField);
        gridForm.Children.Add(txbField);
      }
    }


  }
}