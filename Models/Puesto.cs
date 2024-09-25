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

    [StringLength(50)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? Sueldo { get; set; }

    [InverseProperty("idPuestoNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
