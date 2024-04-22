using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalP1.Models;

public partial class Vendedore
{
    public int IdVendedor { get; set; }
    [Required(ErrorMessage = "Debe ingresar el nombre.")]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "Debe ingresar el apellido.")]
    public string? Apellido { get; set; }

    public string? Telefono { get; set; }

    public string? Cedula { get; set; }

    public string? Salario { get; set; }
}
