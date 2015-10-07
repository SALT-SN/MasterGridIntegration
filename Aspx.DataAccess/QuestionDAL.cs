using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspx.IDAL;
using Aspx.Model;

namespace Aspx.DataAccess
{
    public class QuestionDAL : BaseDAL<ModQuestion>, IQuestion
    {
         /// <summary>
        /// 
        /// </summary>
        /// <param name="tfs"></param>
        /// <returns></returns>
        public List<QuestionView> QueryAll(int lmid)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select *  from Question where lmid=" + lmid);
            return dabase.ReadDataBase.Query<QuestionView>(sb.ToString()).ToList<QuestionView>();
        }
    }
}
