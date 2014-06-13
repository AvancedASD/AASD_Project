using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AASD_WebUI.Controllers
{
    public class NavController : Controller
    {
        public PartialViewResult Menu()
        {
            return PartialView();
        }

    }
}
