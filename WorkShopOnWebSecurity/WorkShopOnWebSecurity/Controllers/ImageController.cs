﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkShopOnWebSecurity.Models;

namespace WorkShopOnWebSecurity.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult Index()
        {
            var model = new ImageViewModel()
            {
                Images = Directory.EnumerateFiles(Server.MapPath("~/Images"))
                          .Select(fn => "~/Images/" + Path.GetFileName(fn))
            };
            return View(model);
        }

        // GET: Image/Details/5
        public ActionResult ImageList()
        {
            var model = new ImageViewModel()
            {
                Images = Directory.EnumerateFiles(Server.MapPath("~/Images"))
                          .Select(fn => "~/Images/" + Path.GetFileName(fn))
            };
            return View(model);
            return View(model);
        }

        // GET: Image/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Image/Create
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

        // GET: Image/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Image/Edit/5
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

        // GET: Image/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Image/Delete/5
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
