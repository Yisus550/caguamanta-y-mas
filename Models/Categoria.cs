using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

public partial class Categoria
{
    [Key]
    public int IdCategoria { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage ="Este campo es obligatorio")]
    public string NombreCategoria { get; set; }

    [StringLength(120, ErrorMessage = "Este campo no debe pasar los 120 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string DescripcionCategoria { get; set; }

	//Llave foranea
	[InverseProperty("CategoriaNavId")]
    public virtual List<Platillo> Platillos { get; set; }
}
