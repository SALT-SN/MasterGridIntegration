using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspx.Model;
using Aspx.Factory;
using Aspx.IDAL;

namespace Aspx.Business
{
    public class BllExample : BllBase<ModExample>
    {
        private IExample DAL = CreateDalFactory.CreateExample();

        public override void SetCurrentReposiotry()
        {
            CurrentDAL = DAL;
        }
    }
}
