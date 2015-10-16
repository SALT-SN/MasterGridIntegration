using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspx.Model;

namespace Aspx.IDAL
{
    public interface ILike : IBaseDAL<ModLike>
    {
        String QueryAll1(int lmid);
    }
}