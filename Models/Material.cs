using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

[Table("Material")]
public partial class Material
{
    [Key]
    public int idM { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? NomM { get; set; }

    public int? Cant { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? Proveedor { get; set; }

    [Column(TypeName = "money")]
    public decimal? costo { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? UnidadMedida { get; set; }

    public DateOnly? fechaCad { get; set; }

    public int? idCate { get; set; }

    public int? stock { get; set; }
}
