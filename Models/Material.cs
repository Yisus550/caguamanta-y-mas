using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

// [Table("Material")]
public partial class Material
{
    [Key]
    public int IdMaterial { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string NombreMaterial { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [Range(0, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0")]
    public int Cantidad { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string Proveedor { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
    public double Costo { get; set; }
}
