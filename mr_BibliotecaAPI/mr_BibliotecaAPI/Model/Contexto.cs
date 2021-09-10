using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mr_BibliotecaAPI.Model
{
    public class Contexto : DbContext
    {
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Livro> Livros { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }
    }
}
