using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

// La tabla no contiene una llave primaria
[Keyless]
public partial class DetalleCompra
{
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public int IdCompra { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    public int IdProducto { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
    public double PrecioUnidad { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [Range(0, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0")]
    public int Cantidad { get; set; }
    
    [Required(ErrorMessage = "Este campo es obligatorio")]
    [Range(0, double.MaxValue, ErrorMessage = "El importe debe ser mayor a 0")]
    public double Importe { get; set; }

    [ForeignKey("IDCompra")]
    public virtual Compra CompraNavId { get; set; }

    [ForeignKey("IDProducto")]
    public virtual Material ProductoNavId { get; set; }
}
