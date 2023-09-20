using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Entity;

public partial class Venda
{
    public int IdVenda { get; set; }

    public string? NumeroVenda { get; set; }

    public int? IdTipoDocumentoVenda { get; set; }

    public int? IdUsuario { get; set; }

    public string? DocumentoCliente { get; set; }

    public string? NomeCliente { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? ImpuestoTotal { get; set; }

    public decimal? Total { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<DetalheVenda> DetalheVenda { get; set; } = new List<DetalheVenda>();

    public virtual TipoDocumentoVenda? IdTipoDocumentoVendaNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
