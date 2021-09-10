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
    public class LivroController : ControllerBase
    {
        public Contexto Contexto;

        public LivroController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]
        [Route("listar")]
        public List<Livro> Listar()
        {
            return Contexto.Livros.ToList();
        }

        [HttpGet("detalhe/{id}")]
        public Livro Detalhe(int id)
        {
            return Contexto.Livros.First(e => e.IdLivro == id);
        }

        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Livro>> PostLivro(Livro livro)
        {
            livro.IdLivro = 0;
            Contexto.Livros.Add(livro);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(PostLivro), new { id = livro.IdLivro });
        }

        [HttpPost]
        [Route("alterar")]
        public async Task<ActionResult<Livro>> UpdateLivro(Livro livro)
        {
            Contexto.Update(livro);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(UpdateLivro), new { id = livro.IdLivro });
        }
    }
}
