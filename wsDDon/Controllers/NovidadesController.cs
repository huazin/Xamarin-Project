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
    public class NovidadesController : ApiController
    {
        NovidadesRepository Db = new NovidadesRepository();
        // GET: api/Novidades
        public IEnumerable<Novidades> Get()
        {
            return Db.List();
        }

        // GET: api/Novidades/5
        public IEnumerable<Novidades> Get(int idioma)
        {
            return Db.List(idioma);
        }
    }
}
