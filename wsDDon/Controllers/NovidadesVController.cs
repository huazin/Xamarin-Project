using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wsDDon.Infra.Repository;
using wsDDon.Models;

namespace wsDDon.Controllers
{
    [Authorize]
    public class NovidadesVController : Controller
    {
        NovidadesRepository Db = new NovidadesRepository();
        // GET: NovidadesV
        public ActionResult Index()
        {
            return View(Db.List().Where(p => p.Excluido == false));
        }

        // GET: NovidadesV/Details/5
        public ActionResult Details(int id)
        {
            return View(Db.FindById(id));
        }

        // GET: NovidadesV/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NovidadesV/Create
        [HttpPost]
        public ActionResult Create(Novidades Nov)
        {
            Nov.Excluido = false;
            if (ModelState.IsValid)
            {
                Db.Add(Nov);
                return RedirectToAction("Index");
            }
            return View(Nov);
        }

        // GET: NovidadesV/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Db.FindById(id));
        }

        // POST: NovidadesV/Edit/5
        [HttpPost]
        public ActionResult Edit(Novidades Nov)
        {
            if (ModelState.IsValid)
            {
                Db.Edit(Nov);
                return RedirectToAction("Index");
            }
            return View(Nov);
        }

        // GET: NovidadesV/Delete/5
        public ActionResult Delete(int id)
        {
            Db.Remove(Db.FindById(id));
            return RedirectToAction("Index");
        }
    }
}
