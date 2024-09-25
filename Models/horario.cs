using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

public partial class horario
{
    [Key]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public int idH { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [StringLength(20, ErrorMessage = "Este campo no debe pasar los 20 caracteres")]
    public string? turno { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    public TimeOnly? HoraEnt { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    public TimeOnly? Horasal { get; set; }

    [InverseProperty("idTurnoNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
