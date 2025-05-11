using OrakYazilimLib.Util.core;
using System.Windows.Controls;

namespace OrakUtilWpf.FiWpfExtension
{
  public static class FiDataGridExt
  {
    public static FiKeybean GetSelectedItemAsFkbOk(this DataGrid dataGrid)
    {

      // Eğer bir satır seçiliyse SelectedItem üzerinden alınabilir
      if (dataGrid?.SelectedItem != null)
      {
        // Veri bağlama nesnesini alıyoruz
        object selectedItem = dataGrid.SelectedItem;

        if (selectedItem is FiKeybean fkbSelected)
        {
          return fkbSelected;
        }

      }
      return null;
    }



  } // end class
}