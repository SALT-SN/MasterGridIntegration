using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspx.IDAL;
using Aspx.Factory;
using Aspx.Model;

namespace Aspx.Business
{
    public class BllQuestion : BllBase<ModQuestion>
    {
        private IQuestion DAL = CreateDalFactory.CreateQuestion();
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
        public List<QuestionView> QueryAll(int lmid)
        {
            var view= DAL.QueryAll(lmid);
            if (view != null)
            {
                BllOption bll = new BllOption();
                for(int i=0;i<view.Count;i++)
                {
                    view[i].OptionList = bll.QueryAll(view[i].qid);
                }
            }
            return view;
        }

    }
}
