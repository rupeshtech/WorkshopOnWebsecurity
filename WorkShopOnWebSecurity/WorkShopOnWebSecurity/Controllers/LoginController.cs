using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkShopOnWebSecurity.Helper;
using WorkShopOnWebSecurity.Models;

namespace WorkShopOnWebSecurity.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        // POST: Login/Create
        [HttpPost]
        public ActionResult Index(SignIn collection)
        {
            try
            {
                if(SqlHelper.Login(collection))
                return RedirectToAction("SuccessfullLogin");
                else
                    return RedirectToAction("UnsuccessfullLogin");
            }
            catch (Exception ex)
            {
                return RedirectToAction("UnsuccessfullLogin");
            }
        }


        public ActionResult SuccessfullLogin()
        {
            return View();
        }

        public ActionResult UnsuccessfullLogin()
        {
            return View();
        }
        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
}
