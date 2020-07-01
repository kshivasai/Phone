using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Phone.Models;

namespace Phone.Viewmodel
{
    public class UserViewModel
    {
        public UserDataModel userDataModel { get; set; }

        public List<UserDataModel> userDataModels { get; set; }
    }
}