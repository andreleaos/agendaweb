using AgendaWebApi.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private static List<Contato> _contatos = new List<Contato>();

        public ContatoController()
        {
            _contatos.Add(new Contato 
            { 
                Id = 1, 
                Nome = "Andre", 
                Email = "andre@gmail.com", 
                Fone = "11 4578-9865" 
            });

            _contatos.Add(new Contato
            {
                Id = 2,
                Nome = "Maria",
                Email = "maria@gmail.com",
                Fone = "11 2356-3658"
            });

            _contatos.Add(new Contato
            {
                Id = 3,
                Nome = "Joao",
                Email = "joao@gmail.com",
                Fone = "11 4365-6598"
            });
        }

        [HttpGet]
        public ActionResult<List<Contato>> GetAll()
        {
            return Ok(_contatos);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Contato> GetById(int id)
        {
            var filtro = _contatos.FirstOrDefault(p => p.Id == id);
            return Ok(filtro);
        }

    }
}
