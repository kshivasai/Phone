using Phone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Security.AccessControl;

namespace Phone.Controllers
{
    public class UserController : Controller
    {
        static List<UserDataModel> PhoneBook = new List<UserDataModel>();
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Enter()
        {
            return View("EnterUser");
        }   
        public ActionResult Submit(UserDataModel data)
        {
            PhoneBook.Add(data);
            return View(data);
        }
      
    }

}
