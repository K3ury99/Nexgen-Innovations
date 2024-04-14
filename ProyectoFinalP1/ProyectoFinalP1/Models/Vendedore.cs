using System;
using System.Collections.Generic;

namespace ProyectoFinalP1.Models;

public partial class Vendedore
{
    public int IdVendedor { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Telefono { get; set; }

    public string? Cedula { get; set; }

    public string? Salario { get; set; }
}
