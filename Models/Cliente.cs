using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

public partial class Cliente
{
    [Key]
    public int idC { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? importancia { get; set; }

    [InverseProperty("IDClienteNavigation")]
    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
