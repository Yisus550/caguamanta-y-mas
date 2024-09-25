using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

[Keyless]
public partial class DetalleVenta
{
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public int IDVenta { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    public int IDProducto { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
    public double PrecioUnidad { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [Range(0, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0")]
    public int Cantidad { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [Range(0, double.MaxValue, ErrorMessage = "El importe debe ser mayor a 0")]
    public double? Importe { get; set; }

    [ForeignKey("IDProducto")]
    public virtual Platillo IDProductoNavigation { get; set; } = null!;

    [ForeignKey("IDVenta")]
    public virtual Ventum IDVentaNavigation { get; set; } = null!;
}
