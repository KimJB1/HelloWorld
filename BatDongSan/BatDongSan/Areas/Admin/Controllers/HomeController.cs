using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BatDongSan.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult IndexHome()
        {
            var myName = "KIm JB";
            return View();
        }
        public ActionResult IndexLogin()
        {
            return View();
        }
    }
}