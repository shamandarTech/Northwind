﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindMvc5.Areas.Administration.Controllers
{
    public class RegionController : Controller
    {
        public RegionController()
        {

        }

        // GET: Administration/Region
        public ActionResult Index()
        {
            return View();
        }

        // GET: Administration/Region/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Administration/Region/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administration/Region/Create
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

        // GET: Administration/Region/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Administration/Region/Edit/5
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

        // GET: Administration/Region/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Administration/Region/Delete/5
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
