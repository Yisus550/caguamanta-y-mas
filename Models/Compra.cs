using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

[Table("Compra")]
public partial class Compra
{
    [Key]
    public int idCompra { get; set; }

    public DateOnly FechaCompra { get; set; }

    public int IDEmpleado { get; set; }

    public int IDProveedor { get; set; }

    [Column(TypeName = "money")]
    public decimal? Importe { get; set; }

    [ForeignKey("IDEmpleado")]
    [InverseProperty("Compras")]
    public virtual Usuario IDEmpleadoNavigation { get; set; } = null!;

    [ForeignKey("IDProveedor")]
    [InverseProperty("Compras")]
    public virtual Proveedore IDProveedorNavigation { get; set; } = null!;
}
