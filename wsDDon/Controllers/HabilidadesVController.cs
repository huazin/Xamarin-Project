using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wsDDon.Infra.Repository;
using wsDDon.Models;

namespace wsDDon.Controllers
{
    public class HabilidadesVController : Controller
    {
        HabilidadesRepository Db = new HabilidadesRepository();
        // GET: HabilidadesV
        [Authorize]
        public ActionResult Index()
        {
            return Redirect("~/Home/Index");
        }

        // GET: HabilidadesV/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            return View(Db.FindById(id));
        }

        // GET: HabilidadesV/Create
        [Authorize]
        public ActionResult Create()
        {
            JobRepository Repo = new JobRepository();
            TempData["Jobs"] = Repo.List().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.Id_Job.ToString()
            });
            return View();
        }

        // POST: HabilidadesV/Create
        [Authorize]
        [HttpPost]
        public ActionResult Create(Habilidades Hab)
        {
            if (ModelState.IsValid)
            {
                Db.Add(Hab);
                return Redirect("~/JobV/Details/" + Hab.id_Job);
            }
            return View(Hab);
        }

        // GET: HabilidadesV/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            JobRepository Repo = new JobRepository();
            TempData["Jobs"] = Repo.List().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.Id_Job.ToString()
            });
            return View(Db.FindById(id));
        }

        // POST: HabilidadesV/Edit/5
        [HttpPost]
        [Authorize]
        public ActionResult Edit(Habilidades Hab)
        {
            if (ModelState.IsValid)
            {
                Db.Edit(Hab);
                return Redirect("~/JobV/Details/" + Hab.id_Job);
            }
            return View(Hab);
        }
    }
}
