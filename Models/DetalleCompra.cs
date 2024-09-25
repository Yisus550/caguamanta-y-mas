using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

[Keyless]
public partial class DetalleCompra
{
    public int IDCompra { get; set; }

    public int IDProducto { get; set; }

    [Column(TypeName = "money")]
    public decimal PrecioUnidad { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "money")]
    public decimal? Importe { get; set; }

    [ForeignKey("IDCompra")]
    public virtual Compra IDCompraNavigation { get; set; } = null!;

    [ForeignKey("IDProducto")]
    public virtual Material IDProductoNavigation { get; set; } = null!;
}
