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

    [DataType(DataType.Date)]
    public DateOnly FechaVenta { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    public int IDEmpleado { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    public int IDCliente { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [Range(0, double.MaxValue, ErrorMessage = "El importe debe ser mayor a 0")]
    public double? Importe { get; set; }

    [ForeignKey("IDCliente")]
    [InverseProperty("Venta")]
    public virtual Cliente IDClienteNavigation { get; set; } = null!;

    [ForeignKey("IDEmpleado")]
    [InverseProperty("Venta")]
    public virtual Usuario IDEmpleadoNavigation { get; set; } = null!;
}
