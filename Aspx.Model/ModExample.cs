using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspx.Model
{
    [Serializable]
    [Dapper.TableNameAttribute("Example")]
    [Dapper.PrimaryKeyAttribute("eid", autoIncrement = false)]


    public class ModExample
    {

        /// <summary>
        /// eid
        /// </summary>		
        private int _eid;
        public int eid
        {
            get { return _eid; }
            set { _eid = value; }
        }
        /// <summary>
        /// lmid
        /// </summary>		
        private int _lmid;
        public int lmid
        {
            get { return _lmid; }
            set { _lmid = value; }
        }
        /// <summary>
        /// edes
        /// </summary>		
        private string _edes;
        public string edes
        {
            get { return _edes; }
            set { _edes = value; }
        }
        /// <summary>
        /// cmposition
        /// </summary>		
        private int _cmposition;
        public int cmposition
        {
            get { return _cmposition; }
            set { _cmposition = value; }
        }
        /// <summary>
        /// uid
        /// </summary>		
        private int _uid;
        public int uid
        {
            get { return _uid; }
            set { _uid = value; }
        }
        /// <summary>
        /// actid
        /// </summary>		
        private long _actid;
        public long actid
        {
            get { return _actid; }
            set { _actid = value; }
        }
        /// <summary>
        /// votes
        /// </summary>		
        private int _votes;
        public int votes
        {
            get { return _votes; }
            set { _votes = value; }
        }        
    }
}
