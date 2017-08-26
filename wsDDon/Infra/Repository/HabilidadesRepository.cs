using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.Repository
{
    public class HabilidadesRepository : ICrud<Habilidades>
    {
        Context Db = new Context();
        public void Add(Habilidades Object)
        {
            Db.Habilidades.Add(Object);
            Db.SaveChanges();
        }

        public void Edit(Habilidades Objecto)
        {
            Db.Entry(Objecto).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public Habilidades FindById(int id)
        {
            return Db.Habilidades.Find(id);
        }

        public IEnumerable<Habilidades> List()
        {
            return Db.Habilidades.ToList();
        }
        public IEnumerable<Habilidades> List(int idioma)
        {
            return Db.Habilidades.Where(p => p.idiomaId == idioma).ToList();
        }

        public IEnumerable<Habilidades> List(int idioma, int id_job)
        {
            return Db.Habilidades.ToList().Where(p => p.idiomaId == idioma && p.id_Job == id_job);
        }

        public void Remove(Habilidades Object)
        {
            Db.Habilidades.Remove(Object);
            Db.SaveChanges();
        }
    }
}