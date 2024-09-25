using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

[Index("Nombre", Name = "UQ__Puestos__75E3EFCF22BEF3D4", IsUnique = true)]
public partial class Puesto
{
    [Key]
    public int idPue { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string Nombre { get; set; } = null!;

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [Range(0, double.MaxValue, ErrorMessage = "El sueldo debe ser mayor a 0")]
    public double? Sueldo { get; set; }

    [InverseProperty("idPuestoNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
