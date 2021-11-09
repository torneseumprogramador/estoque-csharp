using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace controle_estoque.Models.Enum
{
    public enum TipoRegistro
    {
        Entrada = 1,
        Saida = 0
    }
}
