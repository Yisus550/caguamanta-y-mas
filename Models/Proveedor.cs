using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

public partial class Proveedor
{
    [Key]
    public int IdProveedor { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string NombreProveedor { get; set; }

    [Phone]
    [Required(ErrorMessage = "Este campo es obligatorio")]

    public string Telefono { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [EmailAddress(ErrorMessage ="No cumple con la estructura de un Email")]
    public string Correo { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string Empresa { get; set; }

	//Llave foranea

	[InverseProperty("ProveedorNavId")]
    public virtual ICollection<Compra> Compras { get; set; }
}
