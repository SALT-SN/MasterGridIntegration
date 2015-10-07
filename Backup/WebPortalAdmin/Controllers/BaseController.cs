using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aspx.Common;
using Aspx.Business;

namespace WebPortalAdmin.Controllers
{
    public class BaseController<T> : BlankBaseController
    {
        public string Output; //output to the view
        public DataSet _mySet;//DataSet variable
        public string _where=" 1=1 ";//filter

       

        #region ===页面取值

        /// <summary>
        /// get string
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        protected string GetRequestQueryString(string key)
        {
            if (!string.IsNullOrEmpty(Request[key]))
            {
                return Request[key].Trim();
            }
            return string.Empty;
        }

        /// <summary>
        /// get int
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        protected int GetRequestQueryInt(string key)
        {
            return Convert.ToInt32(GetRequestQueryString(key));
        }

        /// <summary>
        /// get datetime
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        protected DateTime GetRequestQueryDateTime(string key)
        {
            return Convert.ToDateTime(GetRequestQueryString(key));
        }
        #endregion


        /// <summary>
        /// output content
        /// </summary>
        /// <param name="jsonResult">信息</param>
        protected void WriteJsonToPage(string jsonResult)
        {
            if (jsonResult == "")
            {
                jsonResult = "{{'msg':'','success':false}}";
            }
            Response.Write(jsonResult);
            Response.End();
        }
    }
}
