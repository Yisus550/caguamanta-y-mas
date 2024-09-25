using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

[Index("Telefono", Name = "UQ__Proveedo__4EC504804A961C80", IsUnique = true)]
[Index("Correo", Name = "UQ__Proveedo__60695A19F78EA2F7", IsUnique = true)]
public partial class Proveedore
{
    [Key]
    public int idProveedor { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string NombrePv { get; set; } = null!;

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string ApellidoPv { get; set; } = null!;

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string Lada { get; set; } = null!;

    [Phone]
    [Required(ErrorMessage = "Este campo es obligatorio")]

    public string Telefono { get; set; } = null!;

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [EmailAddress(ErrorMessage ="No cumple con la estructura de un Email")]
    public string Correo { get; set; } = null!;

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string Empresa { get; set; } = null!;

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string? recurso { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string? Descripcion { get; set; }

    [InverseProperty("IDProveedorNavigation")]
    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
