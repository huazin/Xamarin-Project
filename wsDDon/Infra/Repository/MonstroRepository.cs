using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.Repository
{
    public class MonstroRepository : ICrud<Monstro>
    {
        Context Db = new Context();
        public void Add(Monstro Object)
        {
            Db.Monstro.Add(Object);
            Db.SaveChanges();
        }

        public void Edit(Monstro Objecto)
        {
            Db.Entry(Objecto).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public Monstro FindById(int id)
        {
            return Db.Monstro.Find(id);
        }

        public Monstro FindByName(string nome, int idioma)
        {
            return Db.Monstro.Where(p => p.apelido == nome && p.idiomaid == idioma).First();
        }

        public IEnumerable<Monstro> FindByIdCollection(int id)
        {
            return Db.Monstro.ToList().Where(p => p.id_Monstro == id);
        }

        public IEnumerable<Monstro> List()
        {
            return Db.Monstro.ToList();
        }

        public IEnumerable<Monstro> List(int idioma)
        {
            return Db.Monstro.Where(p => p.idiomaid == idioma).ToList();
        }

        public IEnumerable<Monstro> List(int categoria, int especie, int idioma)
        {
            return Db.Monstro.ToList().Where(p => p.categoria == categoria && p.Id_Especie == especie && p.idiomaid == idioma);
        }

        public IEnumerable<Monstro> FindByIdList(int id)
        {
            return Db.Monstro.ToList().Where(p => p.id_Monstro == id);
        }

        public void Remove(Monstro Object)
        {
            Db.Monstro.Remove(Object);
            Db.SaveChanges();
        }

        public IEnumerable<Monstro> GetAllEspecies(int categoria, int idioma)
        {
            return Db.Monstro.SqlQuery("select especie from Monstro where categoria = {0} and idiomaid = {1} group by especie", categoria, idioma);
        }



    }
}