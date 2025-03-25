using System;
using System.Collections.Generic;

namespace T6_P_EntityFrameworkCore_DB_Frist.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public float Precio { get; set; }

    public int Stock { get; set; }
    public List<PanaderiaProducto> PanaderiasProducto { get; set; } = new List<PanaderiaProducto>();

}
