using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dbAspNet.Controllers
{
    public class UserDashboardController : Controller
    {
        // GET: UserDashboard
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserDashboard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserDashboard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserDashboard/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserDashboard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserDashboard/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserDashboard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserDashboard/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
    public class User : Controller
    {
        // GET: UserDashboard
        public ActionResult UserDashboard()
        {
            // Lấy thông tin của người dùng từ cơ sở dữ liệu hoặc bất kỳ nguồn dữ liệu nào khác
            User user = GetUser();

            // Truyền thông tin người dùng vào View bằng ViewBag hoặc ViewModel
            ViewBag.User = user;

            // Trả về View tương ứng
            return View();
        }

        private User GetUser()
        {
            throw new NotImplementedException();
        }
    }
}
