using jsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPLogin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\SW기술진흥협회 교육\C++ 프로젝트 파일\EquipManager\EquipDataBase.mdf;Integrated Security=True;Connect Timeout=30";

        public ActionResult Login()
        {
            string uid = Request.QueryString["UID"];
            string pwd = Request.QueryString["PWD"];

            if(uid != null)
            {
                SQLDB db = new SQLDB(connStr);
                string r = db.Get($"select password from testusers where id='{uid}'").ToString().Trim();
                if(r == pwd)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}