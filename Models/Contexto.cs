using System;
using controle_estoque.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace controle_estoque.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public Contexto() { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
    }
}
