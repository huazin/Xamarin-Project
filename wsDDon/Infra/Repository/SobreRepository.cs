using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.Repository
{
    public class SobreRepository : ICrud<Sobre>
    {
        Context Db = new Context();
        public void Add(Sobre Object)
        {
            Db.Sobre.Add(Object);
            Db.SaveChanges();
        }

        public void Edit(Sobre Objecto)
        {
            Db.Entry(Objecto).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public Sobre FindById(int id)
        {
            return Db.Sobre.Find(id);
        }

        public IEnumerable<Sobre> List()
        {
            return Db.Sobre.ToList();
        }

        public void Remove(Sobre Object)
        {
            Db.Sobre.Remove(Object);
            Db.SaveChanges();
        }
    }
}