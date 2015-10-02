using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspx.IDAL;
using Aspx.Model;

namespace Aspx.DataAccess
{
    public class OptionDAL : BaseDAL<ModOption>, IOption
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tfs"></param>
        /// <returns></returns>
        public List<ModOption> QueryAll(int qid)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select *  from [Option] where qid=" + qid);
            return dabase.ReadDataBase.Query<ModOption>(sb.ToString()).ToList<ModOption>();
        }
    }
}
