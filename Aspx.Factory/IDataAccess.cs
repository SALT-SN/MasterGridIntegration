using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Aspx.Factory
{
    public abstract class IDataAccess
    {
        public readonly static string path = ConfigurationManager.AppSettings["DAL"];
    }
}
