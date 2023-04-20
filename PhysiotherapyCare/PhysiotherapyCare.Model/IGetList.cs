using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MKH.Library.Clasess.FilterClass;

namespace PhysiotherapyCare.Model
{
    public interface IGetList<T, F>
    {
        List<T> GetAllList(ref string msgRet);
        List<T> GetAllListByID(F Id, ref string msgRet);
        List<T> GetAllListByFilter(List<QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<T> ListObj);
        List<T> GetAllListByDetailRow(F Id, long DetailRowId, ref string msgRet);
    }

}
