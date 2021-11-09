using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace controle_estoque.Models.Entidades
{
    public class Produto
    {
        [Required]
        [Key]
        public int Id {get;set;}

        [Required]
        [MaxLength(100)]
        public string Nome {get;set;}

        [Required]
        [Column(TypeName = "Text")]
        public string Descricao {get;set;}

        [Required]
        public double PrecoCompra {get;set;}

        [Required]
        public double PrecoVenda {get;set;}
    }
}
