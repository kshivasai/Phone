using Phone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Security.AccessControl;
using Phone.Viewmodel;

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
            UserViewModel userViewModel = new UserViewModel();
            userViewModel.userDataModel = new UserDataModel();
            return View("EnterUser",userViewModel);
        }
        public ActionResult Submit(UserDataModel data)
        {
            PhoneBook.Add(data);
            return View(PhoneBook);
        }
        public ActionResult Save(UserDataModel obj)
        {
            PhoneBook.Add(obj);
            return View(PhoneBook);
        }

    }

}
