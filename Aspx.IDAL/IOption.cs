using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspx.Model;

namespace Aspx.IDAL
{
    public interface IOption : IBaseDAL<ModOption>
    {
         /// <summary>
        /// 
        /// </summary>
        /// <param name="tfs"></param>
        /// <returns></returns>
        List<ModOption> QueryAll(int qid);
    }
}
