using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CiclismoDesktopPorCodigo.ModelsArg;

public partial class Localidade
{
    [Key]
    public int Id { get; set; }

    public int DepartamentosId { get; set; }

    [StringLength(250)]
    public string Nombre { get; set; } = null!;

    public int Habitantes { get; set; }

    [ForeignKey("DepartamentosId")]
    [InverseProperty("Localidades")]
    public virtual Departamento Departamentos { get; set; } = null!;
}
