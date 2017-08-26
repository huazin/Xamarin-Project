using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.Repository
{
    public class EspecieRepository : ICrud<Especie>
    {
        Context Db = new Context();
        public void Add(Especie Object)
        {
            Db.Especies.Add(Object);
            Db.SaveChanges();
        }

        public void Edit(Especie Objecto)
        {
            Db.Entry(Objecto).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public Especie FindById(int id)
        {
            return Db.Especies.Find(id);
        }

        public IEnumerable<Especie> List()
        {
            return Db.Especies.ToList();
        }

        public IEnumerable<Especie> List(int categoria, int idioma)
        {
            return Db.Especies
                .Join(Db.Monstro,
                p => p.Id_Especie,
                p2 => p2.Id_Especie,
                (p, p2) => new { Especie = p, Monstro = p2 })
                .Where(p => p.Monstro.categoria == categoria && p.Monstro.idiomaid == idioma)
                .Select(p => p.Especie).Distinct();
        }

        public void Remove(Especie Object)
        {
            Db.Especies.Remove(Object);
            Db.SaveChanges();
        }
    }
}