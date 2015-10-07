using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspx.Model
{
    [Serializable]
    [Dapper.TableNameAttribute("TestResult")]
    [Dapper.PrimaryKeyAttribute("qid", autoIncrement = false)]
    public class ModTestResult
    {
        /// <summary>
        /// uid
        /// </summary>		
        private string _uid;
        public string uid
        {
            get { return _uid; }
            set { _uid = value; }
        }
        /// <summary>
        /// qid
        /// </summary>		
        private string _qid;
        public string qid
        {
            get { return _qid; }
            set { _qid = value; }
        }
        /// <summary>
        /// score
        /// </summary>		
        private string _score;
        public string score
        {
            get { return _score; }
            set { _score = value; }
        }
        /// <summary>
        /// date
        /// </summary>		
        private string _date;
        public string date
        {
            get { return _date; }
            set { _date = value; }
        }        
    }
}
