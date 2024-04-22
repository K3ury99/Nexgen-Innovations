using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalP1.Models;

public partial class Sucursale
{
    public int IdSucursal { get; set; }
    [Required(ErrorMessage = "Debe ingresar el nombre de la sucursal.")]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "Debe ingresar la dirección de la sucursal.")]
    public string? Direccion { get; set; }
    [Required(ErrorMessage = "Debe ingresar el telefono de la sucursal.")]
    public string? Telefono { get; set; }
}
