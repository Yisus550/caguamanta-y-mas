using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

public partial class Venta
{
    [Key]
    public int IdVenta { get; set; }

    [DataType(DataType.Date)]
    public DateOnly FechaVenta { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    public int IdEmpleado { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    public int IdCliente { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [Range(0, double.MaxValue, ErrorMessage = "El importe debe ser mayor a 0")]
    public double Importe { get; set; }

	//Llave foranea

	[ForeignKey("IDCliente")]
    [InverseProperty("Venta")]
    public virtual Cliente ClienteNavId { get; set; }

    [ForeignKey("IDEmpleado")]
    [InverseProperty("Venta")]
    public virtual Usuario EmpleadoNavId{ get; set; }
}
