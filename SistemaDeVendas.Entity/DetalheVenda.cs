using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Entity;

public partial class DetalheVenda
{
    public int IdDetalheVenda { get; set; }

    public int? IdVenda { get; set; }

    public int? IdProduto { get; set; }

    public string? MarcaProduto { get; set; }

    public string? DescricaoProduto { get; set; }

    public string? CategoriaProduto { get; set; }

    public int? Quantidade { get; set; }

    public decimal? Preco { get; set; }

    public decimal? Total { get; set; }

    public virtual Venda? IdVendaNavigation { get; set; }
}
