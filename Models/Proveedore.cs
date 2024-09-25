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

    [StringLength(50)]
    [Unicode(false)]
    public string NombrePv { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ApellidoPv { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string Lada { get; set; } = null!;

    [StringLength(14)]
    [Unicode(false)]
    public string Telefono { get; set; } = null!;

    [StringLength(60)]
    [Unicode(false)]
    public string Correo { get; set; } = null!;

    [StringLength(80)]
    [Unicode(false)]
    public string Empresa { get; set; } = null!;

    [StringLength(60)]
    [Unicode(false)]
    public string? recurso { get; set; }

    [Column(TypeName = "text")]
    public string? Descripcion { get; set; }

    [InverseProperty("IDProveedorNavigation")]
    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
