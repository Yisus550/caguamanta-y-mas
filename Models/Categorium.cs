using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

public partial class Categorium
{
    [Key]
    public int id { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? NomC { get; set; }

    [Column(TypeName = "text")]
    public string? Descripcion { get; set; }

	[InverseProperty("CategoriaNavigation")]
    public virtual ICollection<Platillo> Platillos { get; set; } = new List<Platillo>();
}
