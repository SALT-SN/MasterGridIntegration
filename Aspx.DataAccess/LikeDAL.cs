using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspx.IDAL;
using Aspx.Model;

namespace Aspx.DataAccess
{
    public class LikeDAL : BaseDAL<ModLike>, ILike
    {
        public String QueryAll1(int lmid)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT count(lmid) FROM [Like] where iflike = 1 and lmid=245");
            String asa = "SELECT count(lmid) FROM [Like] where iflike = 1 and lmid=" + lmid;

            return dabase.ExecuteScalar(asa).ToString();


        }
    }
}
