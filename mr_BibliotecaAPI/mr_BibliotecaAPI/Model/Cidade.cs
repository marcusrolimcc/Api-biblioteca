using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mr_BibliotecaAPI.Model
{
    [Table("cidade")]
    public class Cidade
    {
        [Key]
        [Column("idcidade")]
        public int IdCidade { get; set; }
        [Column("nome")]
        public String Nome { get; set; }
        [Column("uf")]
        public String Uf { get; set; }
    }
}
