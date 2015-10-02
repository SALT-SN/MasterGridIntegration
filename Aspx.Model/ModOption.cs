using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspx.Model
{
    [Serializable]
    [Dapper.TableNameAttribute("Option")]
    [Dapper.PrimaryKeyAttribute("opid", autoIncrement = false)]
   public class ModOption
    {
        private int _opid;
        public int opid
        {
            get { return _opid; }
            set { _opid = value; }
        }

        private int _qid;
        public int qid
        {
            get { return _qid; }
            set { _qid = value; }
        }

        private string _choice;
        public string choice
        {
            get { return _choice; }
            set { _choice = value; }
        }

    }
}
