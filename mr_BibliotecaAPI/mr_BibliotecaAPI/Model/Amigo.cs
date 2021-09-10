using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mr_BibliotecaAPI.Model
{
    [Table("amigo")]
    public class Amigo
    {
        [Key]
        [Column("idamigo")]
        public int IdAmigo { get; set; }
        [Column("nome")]
        public String Nome { get; set; }
        [Column("idcidade")]
        public int IdCidade { get; set; }
    }
}
