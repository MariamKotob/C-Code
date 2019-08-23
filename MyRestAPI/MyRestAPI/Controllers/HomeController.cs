using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyRestAPI.Models;

namespace MyRestAPI.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    ViewBag.Title = "Home Page";
        //    LogInModel obj = new LogInModel();
        //    return View(obj);
        //}

        public ActionResult Index(LogInModel objuserlogin)
        {
            var display = Userloginvalues().Where(m => m.UserName == objuserlogin.UserName && m.UserPassword == objuserlogin.UserPassword).FirstOrDefault();
            if (display != null)
            {
                ViewBag.Status = "Logged in successfuly";
                Response.Redirect(HtmlPage1.html);
            }
            else
            {
                ViewBag.Status = "INCORRECT User Name or Password";
            }
            return View(objuserlogin);
        }

        public List<LogInModel> Userloginvalues()
        {
            List<LogInModel> objModel = new List<LogInModel>();
            objModel.Add(new LogInModel { UserName = "user1", UserPassword = "password1" });
            objModel.Add(new LogInModel { UserName = "user2", UserPassword = "password2" });
            objModel.Add(new LogInModel { UserName = "user3", UserPassword = "password3" });
            objModel.Add(new LogInModel { UserName = "user4", UserPassword = "password4" });
            objModel.Add(new LogInModel { UserName = "user5", UserPassword = "password5" });
            return objModel;
        }
    }
}
