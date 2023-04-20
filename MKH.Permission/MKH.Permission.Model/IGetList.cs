using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MKH.Permission.Model
{
    public interface IGetList<T, F>
    {
        List<T> GetAllList(ref string msgRet);
        List<T> GetAllListByID(F Id, ref string msgRet);
        List<T> GetAllListByFilter(List<MKH.Library.Clasess.FilterClass.QueryFilter.ExpressionBuilder.Filter> filter, ref string msgRet);
        int CountAll(List<T> ListObj);
        List<T> GetAllListByDetailRow(F Id, long DetailRowId, ref string msgRet);
    }

}
