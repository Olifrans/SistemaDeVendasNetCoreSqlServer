using System;
using System.Collections.Generic;

namespace SistemaDeVendas.Entity;

public partial class Menu
{
    public int IdMenu { get; set; }

    public string? Descricao { get; set; }

    public int? IdMenuPai { get; set; }

    public string? Icone { get; set; }

    public string? Controlador { get; set; }

    public string? PaginaAcao { get; set; }

    public bool? IsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Menu? IdMenuPaiNavigation { get; set; }

    public virtual ICollection<Menu> InverseIdMenuPaiNavigation { get; set; } = new List<Menu>();

    public virtual ICollection<RolMenu> RolMenus { get; set; } = new List<RolMenu>();
}
