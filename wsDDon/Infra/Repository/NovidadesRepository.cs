using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.Repository
{
    public class NovidadesRepository : ICrud<Novidades>
    {
        Context Db = new Context();
        public void Add(Novidades Object)
        {
            Db.Novidades.Add(Object);
            Db.SaveChanges();
        }

        public void Edit(Novidades Objecto)
        {
            Db.Entry(Objecto).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public Novidades FindById(int id)
        {
            return Db.Novidades.Find(id);
        }

        public IEnumerable<Novidades> List()
        {
            return Db.Novidades.ToList().Where(p => p.Excluido == false);
        }
        public IEnumerable<Novidades> List(int Idioma)
        {
            return Db.Novidades.Where(p => p.Excluido == false && p.IdiomaId == Idioma).Take(5).ToList();
        }

        public void Remove(Novidades Object)
        {
            Object.Excluido = true;
            Edit(Object);
        }
    }
}