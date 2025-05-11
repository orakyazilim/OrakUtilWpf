using OrakYazilimLib.DbGeneric;
using OrakYazilimLib.Util.Collection;
using System.Collections.Generic;

namespace OrakUtilWpf.FiDataContainer
{
  public class FwcList: List<FiwCol>
  {
    public FwcList()
    {
    }

    public FwcList(IEnumerable<FiwCol> collection) : base(collection)
    {
    }

    public static FwcList ToFwcList(FicList ficList)
    {
      FwcList fwcList = new FwcList();

      foreach (FiCol fiCol in ficList)
      {
        FiwCol fiwCol = new FiwCol();
        fiwCol.refFiCol = fiCol;
        fwcList.Add(fiwCol);
      }

      return fwcList;
    }
    public void AddByFiCol(FiCol fiCol)
    {
        FiwCol fiwCol = new FiwCol();
        fiwCol.refFiCol = fiCol;
        this.Add(fiwCol);
    }
  }
}