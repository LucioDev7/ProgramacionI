using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CiclismoDesktopPorCodigo.ModelsArg;

public partial class Provincia
{
    [Key]
    public int Id { get; set; }

    [StringLength(250)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("Provincias")]
    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();
}
