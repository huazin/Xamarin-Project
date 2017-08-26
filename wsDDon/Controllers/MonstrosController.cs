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
    public class MonstrosController : Controller
    {
        MonstroRepository Db = new MonstroRepository();
        // GET: Monstros
        public ActionResult Index()
        {
            EspecieRepository Repo = new EspecieRepository();
            TempData["Especie"] = Repo.List().ToList();
            return View(Db.List());
        }

        // GET: Monstros/Details/5
        public ActionResult Details(int id)
        {
            return View(Db.FindById(id));
        }

        // GET: Monstros/Create
        public ActionResult Create()
        {
            EspecieRepository Repo = new EspecieRepository();
            TempData["Especie"] = Repo.List().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.Id_Especie.ToString()
            });
            return View();
        }

        // POST: Monstros/Create
        [HttpPost]
        public ActionResult Create(Monstro M)
        {
            if (ModelState.IsValid)
            {
                Db.Add(M);
                return RedirectToAction("Index");
            }
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            EspecieRepository Repo = new EspecieRepository();
            TempData["Especie"] = Repo.List().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.Id_Especie.ToString()
            });
            return View(M);
        }

        // GET: Monstros/Edit/5
        public ActionResult Edit(int id)
        {
            EspecieRepository Repo = new EspecieRepository();
            TempData["Especie"] = Repo.List().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.Id_Especie.ToString()
            });
            return View(Db.FindById(id));
        }

        // POST: Monstros/Edit/5
        [HttpPost]
        public ActionResult Edit(Monstro M)
        {
            if (ModelState.IsValid)
            {
                Db.Edit(M);
                return RedirectToAction("Index");
            }
            EspecieRepository Repo = new EspecieRepository();
            TempData["Especie"] = Repo.List().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.Id_Especie.ToString()
            });
            return View(M);
        }

        // GET: Monstros/Delete/5
        public ActionResult Delete(int id)
        {
            return View("Index");
        }

        // POST: Monstros/Delete/5
        [HttpPost]
        public ActionResult Delete(Monstro M)
        {
            if (ModelState.IsValid)
            {
                Db.Remove(M);
                return RedirectToAction("Index");
            }
            return View(M);
        }
    }
}
