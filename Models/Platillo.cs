﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace caguamanta_y_mas.Models;

public partial class Platillo
{
    [Key]
    public int IdPlatillo { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string NombrePlatillo { get; set; }

    [StringLength(80, ErrorMessage = "Este campo no debe pasar los 80 caracteres")]
    [Required(ErrorMessage = "Este campo es obligatorio")]
    public string DescripcionPlatillo { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    public int Categoria { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
    public double PrecioUnidad { get; set; }

	//Llave foranea

	[ForeignKey("Categoria")]
    [InverseProperty("Platillos")]
    public virtual Categoria CategoriaNavId { get; set; }
}
