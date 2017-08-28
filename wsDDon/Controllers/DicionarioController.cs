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
    public class DicionarioController : ApiController
    {
        DicionarioRepository Db = new DicionarioRepository();
        // GET: api/Dicionario
        public IEnumerable<Dicionario> Get()
        {
            return Db.List();
        }

        // GET: api/Dicionario/5
        public IEnumerable<Dicionario> Get(int idioma)
        {
            return Db.List(idioma);
        }

    }
}
