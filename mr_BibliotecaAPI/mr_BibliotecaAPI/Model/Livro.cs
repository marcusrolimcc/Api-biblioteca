using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mr_BibliotecaAPI.Model
{
    [Table("livro")]
    public class Livro
    {
        [Key]
        [Column("idlivro")]
        public int IdLivro { get; set; }
        [Column("nome")]
        public String Nome { get; set; }
        [Column("autor")]
        public String Autor { get; set; }
        [Column("idamigo")]
        public int IdAmigo { get; set; }
    }
}
