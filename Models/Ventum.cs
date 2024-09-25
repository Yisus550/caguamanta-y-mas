using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

public partial class Ventum
{
    [Key]
    public int idVenta { get; set; }

    public DateOnly FechaVenta { get; set; }

    public int IDEmpleado { get; set; }

    public int IDCliente { get; set; }

    [Column(TypeName = "money")]
    public decimal? Importe { get; set; }

    [ForeignKey("IDCliente")]
    [InverseProperty("Venta")]
    public virtual Cliente IDClienteNavigation { get; set; } = null!;

    [ForeignKey("IDEmpleado")]
    [InverseProperty("Venta")]
    public virtual Usuario IDEmpleadoNavigation { get; set; } = null!;
}
