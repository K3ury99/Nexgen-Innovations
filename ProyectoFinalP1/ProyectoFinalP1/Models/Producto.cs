using System;
using System.Collections.Generic;

namespace ProyectoFinalP1.Models;

public partial class Producto
{
    public int IdProductos { get; set; }

    public string? Nombre { get; set; }

    public string? Precio { get; set; }

    public string? Descripcion { get; set; }

    public string? Categoria { get; set; }

    public string? Stock { get; set; }
}
