using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Entity;

public partial class TipoDocumentoVendum
{
    public int IdTipoDocumentoVenda { get; set; }

    public string? Descricao { get; set; }

    public bool? IsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Vendum> Venda { get; set; } = new List<Vendum>();
}
