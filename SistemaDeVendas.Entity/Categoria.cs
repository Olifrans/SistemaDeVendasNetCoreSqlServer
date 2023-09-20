using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Entity;

public partial class Categoria
{
    public int IdCategoria { get; set; }

    public string? Descricao { get; set; }

    public bool? IsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
