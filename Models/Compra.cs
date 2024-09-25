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

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [DataType(DataType.Date)]
    public DateOnly FechaCompra { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    public int IDEmpleado { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    public int IDProveedor { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [Range(0, double.MaxValue, ErrorMessage ="El importe debe ser mayor a 0")]
    public double? Importe { get; set; }

    [ForeignKey("IDEmpleado")]
    [InverseProperty("Compras")]
    public virtual Usuario IDEmpleadoNavigation { get; set; } = null!;

    [ForeignKey("IDProveedor")]
    [InverseProperty("Compras")]
    public virtual Proveedore IDProveedorNavigation { get; set; } = null!;
}
