using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactBAL;
using Entities;

namespace Sheet3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Business db = new Business();
            var records = db.GetEntity();

            return View(records);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Entity p)
        {
            Business db = new Business();
            db.Add(p);

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Business db = new Business();
            var currentRecord = db.Details(id);

            return View(currentRecord);
        }

        public ActionResult Delete(int id)
        {
            Business db = new Business();
            db.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Business db = new Business();
            var record = db.Details(id);

            return View(record);
        }

        [HttpPost]
        public ActionResult Edit(Entity p)
        {
            Business db = new Business();
            db.Update(p);

            return RedirectToAction("Index");
        }

    }
}