﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITrack.Controllers
{
    public class TrackerController : Controller
    {
        // GET: Tracker
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tracker/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tracker/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tracker/Create
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

        // GET: Tracker/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tracker/Edit/5
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

        // GET: Tracker/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tracker/Delete/5
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
