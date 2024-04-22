using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalP1.Models;

public partial class Producto
{
    public int IdProductos { get; set; }
    [Required(ErrorMessage = "Debe ingresar el nombre del producto.")]
    public string? Nombre { get; set; }
    [Required(ErrorMessage = "Debe ingresar el precio de este producto.")]
    public string? Precio { get; set; }

    public string? Descripcion { get; set; }
    [Required(ErrorMessage = "Debe ingresar la categoria de este producto.")]
    public string? Categoria { get; set; }

    public string? Stock { get; set; }
}
