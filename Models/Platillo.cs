using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

public partial class Platillo
{
    [Key]
    public int id { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? NomP { get; set; }

    [Column(TypeName = "text")]
    public string? Descripcion { get; set; }

    public int? Categoria { get; set; }

    [Column(TypeName = "money")]
    public decimal? PrecioUnidad { get; set; }

    [ForeignKey("Categoria")]
    [InverseProperty("Platillos")]
    public virtual Categorium? CategoriaNavigation { get; set; }
}
