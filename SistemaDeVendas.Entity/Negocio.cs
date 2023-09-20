using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Entity;

public partial class Negocio
{
    public int IdNegocio { get; set; }

    public string? UrlLogo { get; set; }

    public string? NomeLogo { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public string? Endereco { get; set; }

    public string? Telefone { get; set; }

    public decimal? PorcentagemImposto { get; set; }

    public string? SimboloMoeda { get; set; }
}
