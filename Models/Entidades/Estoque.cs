using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using controle_estoque.Models.Enum;
using Microsoft.EntityFrameworkCore;

namespace controle_estoque.Models.Entidades
{
    public class Estoque
    {
        [Required]
        [Key]
        public int Id {get;set;}

        [Required]
        public int ProdutoId {get;set;}
        
        [ForeignKey("ProdutoId")]
        public Produto Produto {get;set;}

        [Required]
        public int Quantidade {get;set;}

        [Required]
        public DateTime Data {get;set;}

        [Required]
        public TipoRegistro TipoRegistro {get;set;}
    }
}
