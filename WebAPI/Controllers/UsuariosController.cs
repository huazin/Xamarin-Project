using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class UsuariosController : Controller
    {
        [HttpPost]
        public void Incluir([FromBody] Usuario usuario)
        {
            
        }

        [HttpPut]
        public void Atualizar()
        {

        }

        [HttpGet]
        public IActionResult Ober()
        {
            List<Usuario> usuarios = new List<Usuario>
            {
                new Usuario { Nome = "Renan" },
                new Usuario { Nome = "Renan" },
                new Usuario { Nome = "Renan" },
            };

            return Json(usuarios);
        }

        [HttpDelete]
        public void Exclir()
        {

        }
    }
    public class Usuario
    {
        private static int id = 0;

        public Usuario()
        {
            id++;
            this.Id = id;
            this.Senha = Guid.NewGuid().ToString();
            this.Telefones = new List<Telefone>
            {
                new Telefone{ Numero = 123444},
                new Telefone{ Numero = 988764},
            };
        }

        public int Id { get; private set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public List<Telefone> Telefones { get; set;     }

    }

    public class Telefone
    {       
        public int Id { get; set; }

        public int Numero { get; set; }
    }

}
