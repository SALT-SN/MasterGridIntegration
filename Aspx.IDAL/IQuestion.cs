using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspx.Model;

namespace Aspx.IDAL
{
    public interface IQuestion : IBaseDAL<ModQuestion>
    {
         /// <summary>
        /// 
        /// </summary>
        /// <param name="tfs"></param>
        /// <returns></returns>
        List<QuestionView> QueryAll(int lmid);
    }
}
