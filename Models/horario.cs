using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

public partial class horario
{
    [Key]
    public int idH { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? turno { get; set; }

    public TimeOnly? HoraEnt { get; set; }

    public TimeOnly? Horasal { get; set; }

    [InverseProperty("idTurnoNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
