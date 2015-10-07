﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspx.Model
{
    [Serializable]
    [Dapper.TableNameAttribute("Like")]
    [Dapper.PrimaryKeyAttribute("lmid", autoIncrement = false)]


    public class ModLike
    {
        private int _lmid;
        public int lmid
        {
            get { return _lmid; }
            set { _lmid = value; }
        }

        private String _sid;
        public String sid
        {
            get { return _sid; }
            set { _sid = value; }
        }

        private String _uid;
        public String uid
        {
            get { return _uid; }
            set { _uid = value; }
        }

        private String _gid;
        public String gid
        {
            get { return _gid; }
            set { _gid = value; }
        }

        private string _recdate;
        public string recdate
        {
            get { return _recdate; }
            set { _recdate = value; }
        }

        private string _iflike;
        public string iflike
        {
            get { return _iflike; }
            set { _iflike = value; }
        }
    }
}