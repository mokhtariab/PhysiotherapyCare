using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysiotherapyCare.Model
{
    public interface IInsUpDel<T, F>
    {
        bool InsertEntity(List<T> ListObj, ref string msgRet, ref F idRet);
        bool UpdateEntity(List<T> ListObj, ref string msgRet);
        bool DeleteEntity(List<T> ListObj, ref string msgRet);
    }

}
