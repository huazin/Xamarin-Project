using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.Repository
{
    public class DicionarioRepository : ICrud<Dicionario>
    {
        Context Db = new Context();
        public void Add(Dicionario Object)
        {
            Db.Dicionario.Add(Object);
            Db.SaveChanges();
        }

        public void Edit(Dicionario Objecto)
        {
            Db.Entry(Objecto).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public Dicionario FindById(int id)
        {
            return Db.Dicionario.Find(id);
        }

        public IEnumerable<Dicionario> List()
        {
            return Db.Dicionario.ToList();
        }

        public IEnumerable<Dicionario> List(int idioma)
        {
            return Db.Dicionario.Where(p => p.idiomaid == idioma).ToList();
        }

        public void Remove(Dicionario Object)
        {
            Db.Dicionario.Remove(Object);
            Db.SaveChanges();
        }
    }
}