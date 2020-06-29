using Phone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Phone.Controllers
{
    public class HomeController : Controller
    {
        static List<UserDataModel> PhoneBook = new List<UserDataModel>();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        //public ActionResult Enter()
        //{

        //    return View("EnterUser");
        //}

        //public ActionResult Submit(UserDataModel data)
        //{
        //    return View(data);
        //}
    }
}
