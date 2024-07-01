using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalP1.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }
    [Required(ErrorMessage = "Debe ingresar un nombre.")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "Debe ingresar un apellido.")]
    public string Apellido { get; set; }
    [Required(ErrorMessage = "Debe ingresar una edad.")]
    public string Edad { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Cedula { get; set; }
}
