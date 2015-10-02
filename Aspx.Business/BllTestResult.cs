using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspx.IDAL;
using Aspx.Factory;
using Aspx.Model;

namespace Aspx.Business
{
    public class BllTestResult : BllBase<ModTestResult>
    {
        private ITestResult DAL = CreateDalFactory.CreateTestResult();
        /// <summary>
        /// 工厂映射
        /// </summary>
        public override void SetCurrentReposiotry()
        {
            CurrentDAL = DAL;
        }
    }
}
