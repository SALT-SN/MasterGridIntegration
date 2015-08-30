using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspx.IDAL;
using Aspx.Factory;
using Aspx.Model;

namespace Aspx.Business
{
    public class BllOption : BllBase<ModOption>
    {
        private IOption DAL = CreateDalFactory.CreateOption();
        /// <summary>
        /// 工厂映射
        /// </summary>
        public override void SetCurrentReposiotry()
        {
            CurrentDAL = DAL;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tfs"></param>
        /// <returns></returns>
        public List<ModOption> QueryAll(int qid)
        {
            return DAL.QueryAll(qid);
        }

    }
}
