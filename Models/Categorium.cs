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

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage ="Este campo es obligatorio")]
    public string? NomC { get; set; }

    [StringLength(120, ErrorMessage = "Este campo no debe pasar los 120 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string? Descripcion { get; set; }

	[InverseProperty("CategoriaNavigation")]
    public virtual ICollection<Platillo> Platillos { get; set; } = new List<Platillo>();
}
