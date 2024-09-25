using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

public partial class Usuario
{
    [Key]
    public int IdUsuario { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string Nombres { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string Apellidos { get; set; }

    [Phone]
    public string Telefono { get; set; }

    [EmailAddress]
    public string Correo { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string Usuario1 { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string Contraseña { get; set; }

	//Llave foranea

	[InverseProperty("EmpleadoNavId")]
    public virtual ICollection<Compra> Compras { get; set; }

    [InverseProperty("EmpleadoNavId")]
    public virtual ICollection<Venta> Venta { get; set; }
}
