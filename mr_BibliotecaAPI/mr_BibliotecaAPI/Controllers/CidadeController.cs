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
    public class CidadeController : ControllerBase
    {
        public Contexto Contexto;

        public CidadeController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }
        [HttpGet]
        [Route("listar")]
        public List<Cidade> Listar()
        {
            return Contexto.Cidades.ToList();
        }

        [HttpGet("detalhe/{id}")]
        public Cidade Detalhe(int id)
        {
            return Contexto.Cidades.First(e => e.IdCidade == id);
        }

        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<Cidade>> PostCidade(Cidade cidade)
        {
            cidade.IdCidade = 0;
            Contexto.Cidades.Add(cidade);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(PostCidade), new { id = cidade.IdCidade });
        }

        [HttpPost]
        [Route("alterar")]
        public async Task<ActionResult<Cidade>> UpdateCidade(Cidade cidade)
        {
            Contexto.Update(cidade);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(UpdateCidade), new { id = cidade.IdCidade });
        }
    }
}
