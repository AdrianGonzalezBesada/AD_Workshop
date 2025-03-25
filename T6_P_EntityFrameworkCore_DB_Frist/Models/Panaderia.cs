using System;
using System.Collections.Generic;

namespace T6_P_EntityFrameworkCore_DB_Frist.Models;

public partial class Panaderia
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }
    public List<PanaderiaProducto> PanaderiasProducto { get; set; } = new List<PanaderiaProducto>();
}
