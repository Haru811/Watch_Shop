using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using System.Web.Security;
using WatchShop.DBContext;

namespace WatchShop.Controllers
{
    public class AccountController : Controller
    {
        WatchWebEntities1 db1 = new WatchWebEntities1();
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Signup(user u)
        {
           db1.users.Add(u);
            if (db1.SaveChanges() > 0){
                return RedirectToAction("Login");
            }
            return View();
        }  

        public ActionResult Login()
        {   
            return View(); 
        }
        [HttpPost]

        public ActionResult Login(user u,string ReturnUrl)
        {
            if(ModelState.IsValid)
            {
                var user = db1.users.Where(x => x.username == u.username && x.password == u.password).FirstOrDefault();
                if(user != null)
                {
                    FormsAuthentication.SetAuthCookie(u.username,false);
                    Session["uname"] = u.username.ToString();

                    if(ReturnUrl != null){return Redirect(ReturnUrl);}

                    else{return Redirect("/Home/Index");}
                 }
            }
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["uname"] = null;
            return Redirect("Login");
        }
    }
}