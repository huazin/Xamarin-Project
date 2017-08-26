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
    public class HabilidadesController : ApiController
    {
        HabilidadesRepository Db = new HabilidadesRepository();
        // GET: api/Habilidades
        public IEnumerable<Habilidades> Get(int idioma, int id_Job)
        {
            return Db.List(idioma, id_Job);
        }

        // GET: api/Habilidades/5
        public Habilidades Get(int id)
        {
            return Db.FindById(id);
        }

        public IEnumerable<Habilidades> Get()
        {
            return Db.List();
        }

        public IEnumerable<Habilidades> Get(int idioma, string idiomas)
        {
            return Db.List(idioma);
        }


    }
}
