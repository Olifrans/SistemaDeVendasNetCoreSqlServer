using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Entity;

public partial class Produto
{
    public int IdProduto { get; set; }

    public string? CodigoBarra { get; set; }

    public string? Marca { get; set; }

    public string? Descricao { get; set; }

    public int? IdCategoria { get; set; }

    public int? Stock { get; set; }

    public string? UrlImagen { get; set; }

    public string? NomeImagen { get; set; }

    public decimal? Preco { get; set; }

    public bool? IsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Categoria? IdCategoriaNavigation { get; set; }
}
