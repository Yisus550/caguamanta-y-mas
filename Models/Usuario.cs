using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

[Index("Correo", Name = "UQ__Usuarios__60695A192D3A4610", IsUnique = true)]
[Index("usuario1", Name = "UQ__Usuarios__9AFF8FC6E1B486FF", IsUnique = true)]
[Index("Dir", Name = "UQ__Usuarios__C031220B5B7F827D", IsUnique = true)]
[Index("Tel", Name = "UQ__Usuarios__C451FA8DFC154154", IsUnique = true)]
public partial class Usuario
{
    [Key]
    public int idU { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string? Nombres { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string? Apellidos { get; set; }

    public int? idPuesto { get; set; }

    [DataType(DataType.Date)]
    public DateOnly? FhNa { get; set; }

    [DataType(DataType.Date)]
    public DateOnly? FhCon { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string? Dir { get; set; }

    [Phone]
    public string? Tel { get; set; }

    [EmailAddress]
    public string? Correo { get; set; }

    public int? idTurno { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string? usuario1 { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string? contraseña { get; set; }

    [InverseProperty("IDEmpleadoNavigation")]
    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    [InverseProperty("IDEmpleadoNavigation")]
    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();

    [ForeignKey("idPuesto")]
    [InverseProperty("Usuarios")]
    public virtual Puesto? idPuestoNavigation { get; set; }

    [ForeignKey("idTurno")]
    [InverseProperty("Usuarios")]
    public virtual horario? idTurnoNavigation { get; set; }
}
