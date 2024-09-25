using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

[Keyless]
public partial class DetalleVenta
{
    public int IDVenta { get; set; }

    public int IDProducto { get; set; }

    [Column(TypeName = "money")]
    public decimal PrecioUnidad { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "money")]
    public decimal? Importe { get; set; }

    [ForeignKey("IDProducto")]
    public virtual Platillo IDProductoNavigation { get; set; } = null!;

    [ForeignKey("IDVenta")]
    public virtual Ventum IDVentaNavigation { get; set; } = null!;
}
