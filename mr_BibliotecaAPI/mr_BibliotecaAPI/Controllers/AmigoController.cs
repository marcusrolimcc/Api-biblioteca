using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mr_BibliotecaAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mr_BibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmigoController : ControllerBase
    {
        public Contexto Contexto;

        public AmigoController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }
        [HttpGet]
        [Route("listar")]
        public List<Amigo> Listar()
        {
            return Contexto.Amigos.ToList();
        }

        [HttpGet("detalhe/{id}")]
        public Amigo Detalhe(int id)
        {
            return Contexto.Amigos.First(e => e.IdAmigo == id);
        }

        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Amigo>> PostAmigo(Amigo amigo)
        {
            amigo.IdAmigo = 0;
            Contexto.Amigos.Add(amigo);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(PostAmigo), new { id = amigo.IdAmigo });
        }

        [HttpPost]
        [Route("alterar")]
        public async Task<ActionResult<Amigo>> UpdateAmigo(Amigo amigo)
        {
            Contexto.Update(amigo);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(UpdateAmigo), new { id = amigo.IdAmigo });
        }
    }
}
