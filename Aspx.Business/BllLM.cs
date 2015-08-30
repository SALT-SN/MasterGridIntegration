using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspx.IDAL;
using Aspx.Factory;
using Aspx.Model;

namespace Aspx.Business
{
    public class BllLM : BllBase<ModLM>
    {
        private ILM DAL = CreateDalFactory.CreateLM();
        /// <summary>
        /// 工厂映射
        /// </summary>
        public override void SetCurrentReposiotry()
        {
            CurrentDAL = DAL;
        }

        /// <summary>
        /// 根据主键获取详细信息
        /// </summary>
        /// <param name="lmid"></param>
        /// <returns></returns>
        public ModLmView getMode(int lmid)
        {
            ModLmView view = new ModLmView();
            view.lm = base.LoadData(lmid);
            
            if (view.lm != null)
            {
                view.Example = new BllExample().LoadData(view.lm.lmid);
            }

            //search Test
            view.QuestionList = new BllQuestion().QueryAll(lmid);
            
            return view;
        }



    }
}
