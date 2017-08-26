using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.Repository
{
    public class PassivasRepository : ICrud<Passivas>
    {
        Context Db = new Context();
        public void Add(Passivas Object)
        {
            Db.Passivas.Add(Object);
            Db.SaveChanges();
        }

        public void Edit(Passivas Objecto)
        {
            Db.Entry(Objecto).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public Passivas FindById(int id)
        {
            return Db.Passivas.Find(id);
        }

        public IEnumerable<Passivas> List()
        {
            return Db.Passivas.ToList();
        }

        public IEnumerable<Passivas> List(int idioma)
        {
            return Db.Passivas.Where(p=> p.idiomaId == idioma).ToList();
        }

        public IEnumerable<Passivas> List(int idioma, int id_job)
        {
            return Db.Passivas.ToList().Where(p => p.idiomaId == idioma && p.id_Job == id_job);
        }

        public void Remove(Passivas Object)
        {
            Db.Passivas.Remove(Object);
            Db.SaveChanges();
        }
    }
}