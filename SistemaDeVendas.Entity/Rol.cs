using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Entity;

public partial class Rol
{
    public int IdRol { get; set; }

    public string? Descricao { get; set; }

    public bool? IsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<RolMenu> RolMenus { get; set; } = new List<RolMenu>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
