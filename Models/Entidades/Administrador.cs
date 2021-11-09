using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace controle_estoque.Models.Entidades
{
    public class Administrador
    {
        [Required]
        [Key]
        public int Id {get;set;}

        [Required]
        [MaxLength(100)]
        public string Nome {get;set;}

        [Required]
        [MaxLength(255)]
        public string Email {get;set;}

        [Required]
        [MaxLength(10)]
        public string Senha {get;set;}
    }
}
