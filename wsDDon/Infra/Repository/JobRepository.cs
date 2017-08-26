using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wsDDon.Models;

namespace wsDDon.Infra.Repository
{
    public class JobRepository : ICrud<Job>
    {
        Context Db = new Context();
        public void Add(Job Object)
        {
            Db.Jobs.Add(Object);
            Db.SaveChanges();
        }

        public void Edit(Job Objecto)
        {
            Db.Entry(Objecto).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public Job FindById(int id)
        {
            return Db.Jobs.Find(id);
        }

        public IEnumerable<Job> List()
        {
            return Db.Jobs.ToList();
        }

        public void Remove(Job Object)
        {
            Db.Jobs.Remove(Object);
            Db.SaveChanges();
        }
    }
}