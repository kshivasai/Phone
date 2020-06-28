using Phone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Runtime.CompilerServices;
using Phone.Models;
using System.Collections;

namespace Phone.Controllers
{
    public class UserController : Controller
    {
       
        // GET: User
        public ActionResult Dashboard()
        { 
            return View();
        }
        public ActionResult Enter()
        {
            return View("EnterUser");
        }   
        public ActionResult Submit(UserData data)
        {
           
         
            //UserData userData = new UserData();
            //userData.Name = Request.Form["Name"];
            //userData.Address_line_1 = Request.Form["Address_line_1"];
            //userData.Address_line_2 = Request.Form["Address_line_2"];
            //userData.City = Request.Form["City"];
            //userData.Pincode = Request.Form["Pincode"];
            //userData.Phonenumber = Request.Form["Phonenumber"];

            return View(data);
        }
      
    }

}
