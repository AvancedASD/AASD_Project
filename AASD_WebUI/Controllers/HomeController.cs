using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using AASD_WebUI.Models;

namespace AASD_WebUI.Controllers
{
    public class HomeController : Controller
    {      
        public ViewResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string request = "")
        {
            //if (!string.IsNullOrEmpty(request) && request.Length < 50)
            //{
            //    return "Incorrect request";
            //}
            //return request;
           return Redirect(Url.Action("List","Result", request));
        }

    }
}
