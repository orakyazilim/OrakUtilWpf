using OrakYazilimLib.Util.core;
using System.Windows.Controls;

namespace OrakUtilWpf.FiWpfExtension
{
  public static class FiDataGridExt
  {
    public static FiKeybean GetSelectedItemAsFkbFi(this DataGrid dataGrid)
    {

      // Eğer bir satır seçiliyse SelectedItem üzerinden alınabilir
      if (dataGrid?.SelectedItem == null) return null;
      // Veri bağlama nesnesini alıyoruz
      object selectedItem = dataGrid.SelectedItem;

      // selectedItem FiKeybean tipinde ise, fkbSelected olarak al
      if (selectedItem is FiKeybean fkbSelected)
      {
        return fkbSelected;
      }

      return null;
    }



  } // end class
}