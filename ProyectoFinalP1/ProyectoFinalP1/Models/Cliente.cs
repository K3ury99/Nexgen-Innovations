using System;
using System.Collections.Generic;

namespace ProyectoFinalP1.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Edad { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Cedula { get; set; }
}
