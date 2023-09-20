using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Entity;

public partial class TipoDocumentoVenda
{
    public int IdTipoDocumentoVenda { get; set; }

    public string? Descricao { get; set; }

    public bool? IsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Venda> Venda { get; set; } = new List<Venda>();
}
