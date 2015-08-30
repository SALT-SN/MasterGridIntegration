using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspx.Model
{
    [Serializable]
    [Dapper.TableNameAttribute("LM")]
    [Dapper.PrimaryKeyAttribute("lmid", autoIncrement = false)]
   public class ModLM
    {
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
        /// cid
        /// </summary>		
        private int _cid;
        public int cid
        {
            get { return _cid; }
            set { _cid = value; }
        }
        /// <summary>
        /// lmname
        /// </summary>		
        private string _lmname;
        public string lmname
        {
            get { return _lmname; }
            set { _lmname = value; }
        }
        /// <summary>
        /// lmdes
        /// </summary>		
        private string _lmdes;
        public string lmdes
        {
            get { return _lmdes; }
            set { _lmdes = value; }
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
        /// <summary>
        /// isDraft
        /// </summary>		
        private bool _isdraft;
        public bool isDraft
        {
            get { return _isdraft; }
            set { _isdraft = value; }
        }
        /// <summary>
        /// showAfter
        /// </summary>		
        private string _showafter;
        public string showAfter
        {
            get { return _showafter; }
            set { _showafter = value; }
        }
        /// <summary>
        /// lastEditTime
        /// </summary>		
        private DateTime _lastedittime;
        public DateTime lastEditTime
        {
            get { return _lastedittime; }
            set { _lastedittime = value; }
        }        
    }
}
