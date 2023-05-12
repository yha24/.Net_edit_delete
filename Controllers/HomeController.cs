using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dbAspNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Trang bạn mô tả.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Trang bạn liên hệ.";

            return View();
        }
    }
}