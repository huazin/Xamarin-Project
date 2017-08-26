using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using wsDDon.Infra.Repository;
using wsDDon.Models;

namespace wsDDon.Controllers
{
    public class PassivasController : ApiController
    {
        PassivasRepository Db = new PassivasRepository();
        // GET: api/Passivas
        public IEnumerable<Passivas> Get(int idioma, int id_Job)
        {
            return Db.List(idioma, id_Job);
        }

        // GET: api/Passivas/5
        public Passivas Get(int id)
        {
            return Db.FindById(id);
        }

        public IEnumerable<Passivas> Get()
        {
            return Db.List();
        }

        public IEnumerable<Passivas> Get(int idioma, string idiomas)
        {
            return Db.List(idioma);
        }
    }
}
