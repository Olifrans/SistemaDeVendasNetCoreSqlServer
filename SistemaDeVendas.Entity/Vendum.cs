using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Entity;

public partial class Vendum
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

    public virtual ICollection<DetalheVendum> DetalheVenda { get; set; } = new List<DetalheVendum>();

    public virtual TipoDocumentoVendum? IdTipoDocumentoVendaNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
