using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

public partial class Cliente
{
    [Key]
    public int IdCliente { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string Nombre { get; set; }

    [Phone]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string Telefono { get; set; }

    [InverseProperty("ClienteNavId")]
    public virtual ICollection<Venta> Venta { get; set; }
}
