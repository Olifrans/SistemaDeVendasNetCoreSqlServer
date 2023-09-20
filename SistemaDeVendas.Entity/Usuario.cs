using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Entity;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public string? Telefone { get; set; }

    public int? IdRol { get; set; }

    public string? UrlFoto { get; set; }

    public string? NomeFoto { get; set; }

    public string? Dica { get; set; }

    public bool? IsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Rol? IdRolNavigation { get; set; }

    public virtual ICollection<Vendum> Venda { get; set; } = new List<Vendum>();
}
