using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Entity;

public partial class NumeroCorrelativo
{
    public int IdNumeroCorrelativo { get; set; }

    public int? UltimoNumero { get; set; }

    public int? QuantidadeDigitos { get; set; }

    public string? Gerenciamento { get; set; }

    public DateTime? FechaActualizacion { get; set; }
}
