using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.Repository
{
    public class LabelsIdiomasRepository : ICrud<LabelsIdiomas>
    {
        public Context Db = new Context();
        public void Add(LabelsIdiomas Object)
        {
            Db.LabelsIdiomas.Add(Object);
            Db.SaveChanges();
        }

        public void Edit(LabelsIdiomas Objecto)
        {
            Db.Entry(Objecto).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public LabelsIdiomas FindById(int id)
        {
            return Db.LabelsIdiomas.Find(id);
        }

        public IEnumerable<LabelsIdiomas> List()
        {
            return Db.LabelsIdiomas.ToList();
        }

        public void Remove(LabelsIdiomas Object)
        {
            Db.LabelsIdiomas.Remove(Object);
            Db.SaveChanges();
        }
    }
}