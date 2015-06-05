﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Core.BusinessLayer;
using NorthwindMvc5.Services;

namespace NorthwindMvc5.Areas.Administration.Controllers
{
    public class CustomerController : Controller
    {
        protected ISalesUow Uow;

        public CustomerController(IUowService service)
        {
            Uow = service.GetSalesUow();
        }

        protected override void Dispose(bool disposing)
        {
            if (Uow != null)
            {
                Uow.Dispose();
            }

            base.Dispose(disposing);
        }

        // GET: Administration/Customer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Administration/Customer/Details/5
        public ActionResult Details(Int32 id)
        {
            return View();
        }

        // GET: Administration/Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administration/Customer/Create
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

        // GET: Administration/Customer/Edit/5
        public ActionResult Edit(Int32 id)
        {
            return View();
        }

        // POST: Administration/Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(Int32 id, FormCollection collection)
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

        // GET: Administration/Customer/Delete/5
        public ActionResult Delete(Int32 id)
        {
            return View();
        }

        // POST: Administration/Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(Int32 id, FormCollection collection)
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