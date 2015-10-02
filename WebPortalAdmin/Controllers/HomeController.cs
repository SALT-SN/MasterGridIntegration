using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aspx.Business;
using Aspx.Model;
using System.Management;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.IO;

namespace WebPortalAdmin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();

        }
        [HttpGet]
        public ActionResult Example()
        {
            int lmid1 = Convert.ToInt32(Session["lmii"]);
            var sid1 = Session["ss"];
            var uid1 =Session["uu"];
            var gid1 = Session["gg"];
            ModLMRec mode2 = new ModLMRec();
            mode2.lmid = lmid1;
            mode2.sid = sid1.ToString();
            mode2.uid = uid1.ToString();
            mode2.gid = gid1.ToString();
            mode2.ifsucceed = "example";
            mode2.recdate = DateTime.Now.ToLocalTime().ToString();
            var a = new BllLMRec().Insert(mode2);
            String cc3 = "http://adapt2.sis.pitt.edu/cbum/um?app=37&act=" + lmid1 + "&sub=" + lmid1 + "_" + mode2.ifsucceed + "&usr=" + mode2.uid + "&grp=" + mode2.gid + "&sid=" + mode2.sid + "&svc=" + "m";
            HttpWebResponse rs = (HttpWebResponse)HttpWebRequest.Create(cc3.ToString()).GetResponse();
            // Response.Write("<script language='javascript'>window.open('" + cc + "');</script>");
           // Process ps3 = new Process();
           // Process.Start(cc3);
            return null;
          
        }



        [HttpGet]
        public ActionResult Test()
        {
            int lmid1 = Convert.ToInt32(Session["lmii"]);
            var sid1 = Session["ss"];
            var uid1 = Session["uu"];
            var gid1 = Session["gg"];
            ModLMRec mode2 = new ModLMRec();
            mode2.lmid = lmid1;
            mode2.sid = sid1.ToString();
            mode2.uid = uid1.ToString();
            mode2.gid = gid1.ToString();
            mode2.ifsucceed = "test";
            mode2.recdate = DateTime.Now.ToLocalTime().ToString();
            var a = new BllLMRec().Insert(mode2);
            String cc3 = "http://adapt2.sis.pitt.edu/cbum/um?app=37&act=" + lmid1 + "&sub=" + lmid1 + "_" + mode2.ifsucceed + "&usr=" + mode2.uid + "&grp=" + mode2.gid + "&sid=" + mode2.sid + "&res=-1&svc=" + "m";
            HttpWebResponse rs = (HttpWebResponse)HttpWebRequest.Create(cc3.ToString()).GetResponse();
            // Response.Write("<script language='javascript'>window.open('" + cc + "');</script>");
           // Process ps3 = new Process();
           // Process.Start(cc3);
            return null;

        }

        [HttpGet]
        public ActionResult Dess()
        {
            int lmid = Convert.ToInt32(Request["lmid"] == null ? "" : Request["lmid"]);
            String sid = Request["sid"] == null ? "0" : Request["sid"];
            String gid = Request["grp"] == null ? "0" : Request["grp"];
            String uid = Request["usr"] == null ? "0" : Request["usr"];
            Session["ss"] = sid;
            Session["uu"] = uid;
            Session["gg"] = gid;
            Session["lmii"] = lmid;
            /*if (lmid == 0)
            {
                return View("lmid can't be empty");
            }*/

            var view = new BllLM().getMode(lmid);
            ModLMRec mode = new ModLMRec();
            mode.lmid = lmid;
            mode.sid = sid;
            mode.uid = uid;
            mode.gid = gid;
            String status = "";
            if (view.lm != null)
            {
                mode.ifsucceed = "s";
                status = "description";
            }
            else
            {
                mode.ifsucceed = "u";
                status = "UnSucceed";
            }
            mode.recdate = DateTime.Now.ToLocalTime().ToString();
            var a = new BllLMRec().Insert(mode);

            String cc = "http://adapt2.sis.pitt.edu/cbum/um?app=37&act=" + mode.lmid + "&sub=" + lmid + "_" + status + "&usr=" + mode.uid + "&grp=" + mode.gid + "&sid=" + mode.sid + "&svc=" +"m";

            // Response.Write("<script language='javascript'>window.open('" + cc + "');</script>");
            //Process ps2 = new Process();
            // Process.Start(cc);
            //Windows.System.Launcher.LaunchUriAsync(new Uri(cc));
            HttpWebResponse rs = (HttpWebResponse)HttpWebRequest.Create(cc.ToString()).GetResponse();

            return null;

        }
        /// <summary>
        /// detail viewer
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowPage()
        {
            int lmid = Convert.ToInt32(Request["lmid"] == null ? "" : Request["lmid"]);
            String sid = Request["sid"] == null ? "0" : Request["sid"];
            String gid = Request["grp"] == null ? "0" : Request["grp"];
            String uid = Request["usr"] == null ? "0" : Request["usr"];
            Session["ss"] = sid;
            Session["uu"] = uid;
            Session["gg"] = gid;
            Session["lmii"] = lmid;
            /*if (lmid == 0)
            {
                return View("lmid can't be empty");
            }*/
          
            var view = new BllLM().getMode(lmid);
            ModLMRec mode = new ModLMRec();
            mode.lmid =lmid;
            mode.sid = sid;
            mode.uid = uid;
            mode.gid = gid;
            String status ="";
            if (view.lm != null)
            {
                mode.ifsucceed = "s";
                status="description";
            }
            else
            {
                mode.ifsucceed = "u";
                status = "UnSucceed";
            }
            mode.recdate = DateTime.Now.ToLocalTime().ToString();
            var a = new BllLMRec().Insert(mode);
            
            String cc = "http://adapt2.sis.pitt.edu/cbum/um?app=37&act="+mode.lmid +"&sub=" + lmid +"_"+ status + "&usr=" + mode.uid + "&grp=" + mode.gid + "&sid=" + mode.sid +"&svc=" + "m";
            
           // Response.Write("<script language='javascript'>window.open('" + cc + "');</script>");
            //Process ps2 = new Process();
           // Process.Start(cc);
            //Windows.System.Launcher.LaunchUriAsync(new Uri(cc));
            HttpWebResponse rs = (HttpWebResponse)HttpWebRequest.Create(cc.ToString()).GetResponse();

            if (view != null)
            {
                ViewData["lmname"] = "";//topic
                ViewData["lmdes"] = "";//content
                ViewData["edes"] = "";//
                if (view.lm != null)
                {
                    ViewData["lmname"] = view.lm.lmname;
                    ViewData["lmdes"] = view.lm.lmdes;
                }
                if (view.Example != null)
                {
                    ViewData["edes"] = view.Example.edes;
                }
                if (view.QuestionList.Count>0)
                {
                    ViewData["QuestionList"] = view.QuestionList;
                }
                return View();
            }
            else
            {
                return View("No data");
            }

            

        }

     
        /// <summary>
        /// 删除
        /// </summary>
        public JsonResult SubmitTest(string id)
        {
            
            var json = new ModJsonResult();
            try
            {
                int RightNum = Convert.ToInt32(Request["RightNum"] == null ? "" : Request["RightNum"]);
                var lmid = (Request["lmid"] == null ? "" : Request["lmid"]);
                var session = Session["ss"];
                var uu = Session["uu"];
                var gg = Session["gg"];
                /*string url2 = HttpContext.Request.Url.Query;
                url2 = url2.Replace("?", "");
                string[] urlpa = url2.Split('&');
                int co = 0;
                string session = "";
                foreach (string s in urlpa)
                {
                    string[] val = s.Split('=');
                    string co2=val[co];
                    if (co2=="sid"){
                        session = val[co + 1];
                    }
                }*/
                
                BllTestResult bll = new BllTestResult();
                ModTestResult model = new ModTestResult();
                model.uid = uu.ToString();
                model.qid = lmid;
                model.score = RightNum.ToString();
                model.date = session.ToString();
                float d = (float)RightNum / 100;
                int result = bll.Insert(model);
                String cc2 = "http://adapt2.sis.pitt.edu/cbum/um?app=37&act=" + model.qid + "&sub=" + lmid + "_test" + "&grp=" + gg + "&usr=" + model.uid + "&sid=" + model.date + "&res="+ d +"&svc=" + "m";
               //Process ps = new Process();
              // Process.Start(cc2);
                HttpWebResponse rs = (HttpWebResponse)HttpWebRequest.Create(cc2.ToString()).GetResponse();
               // Response.Write("<script language='javascript'>window.open('" + cc2 + "');</script>");
                if (result>0)
                {
                    json.success =true;
                }
                else
                {
                    json.success = false;
                    json.msg = " Failed!";
                }
            }
            catch (Exception ex)
            {
                json.success = false;
                json.msg = "Error：" + ex.Message;
            }
            return Json(json);
        }
 
    }
}
