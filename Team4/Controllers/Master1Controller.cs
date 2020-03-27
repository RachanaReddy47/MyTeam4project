using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team4.Models;

namespace Team4.Controllers
{
    public class Master1Controller : Controller
    {
        // GET: Master1
        public ActionResult Index()
        {
            return View("Index", "_MyMasterPage1");
        }

        [HttpPost]
        public ActionResult Index(Login_Table lt,string val)
        {
            if(val=="Login")
            {
             Login_Table l=   DBOperations.SendType(lt);
                if(l.UserType=="Customer")
                {
                   return  RedirectToAction("_CustomerLayoutPage");
                }

                else
                {
                    return RedirectToAction("_AdminLayoutPage");
                }
            }
            else if(val=="New User")
            {
                return View("RegistrnPage");
            }
            return View();
        }



    }
}