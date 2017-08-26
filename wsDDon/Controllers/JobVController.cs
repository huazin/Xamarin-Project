using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wsDDon.Infra.Repository;
using wsDDon.Models;

namespace wsDDon.Controllers
{
    public class JobVController : Controller
    {
        JobRepository Db = new JobRepository();
        // GET: JobV
        [Authorize]
        public ActionResult Index()
        {
            return View(Db.List());
        }

        // GET: JobV/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            Job job = Db.FindById(id);
            TempData["HabPt"] = new HabilidadesRepository().List(1, job.Id_Job).ToList();
            TempData["HabUs"] = new HabilidadesRepository().List(2, job.Id_Job).ToList();

            TempData["PasPt"] = new PassivasRepository().List(1, job.Id_Job).ToList();
            TempData["PasUs"] = new PassivasRepository().List(2, job.Id_Job).ToList();

            return View(job);
        }

        // GET: JobV/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobV/Create
        [HttpPost]
        [Authorize]
        public ActionResult Create(Job job)
        {
            if (ModelState.IsValid)
            {
                Db.Add(job);
                return RedirectToAction("Index");
            }
            return View(job);

        }

        // GET: JobV/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            return View(Db.FindById(id));
        }

        // POST: JobV/Edit/5
        [HttpPost]
        [Authorize]
        public ActionResult Edit(Job job)
        {
            if (ModelState.IsValid)
            {
                Db.Edit(job);
                return RedirectToAction("Index");
            }
            return View(job);
        }
    }
}
