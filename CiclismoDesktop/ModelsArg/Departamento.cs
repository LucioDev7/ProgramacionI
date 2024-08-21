using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CiclismoDesktopPorCodigo.ModelsArg;

public partial class Departamento
{
    [Key]
    public int Id { get; set; }

    public int ProvinciasId { get; set; }

    [StringLength(250)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("Departamentos")]
    public virtual ICollection<Localidade> Localidades { get; set; } = new List<Localidade>();

    [ForeignKey("ProvinciasId")]
    [InverseProperty("Departamentos")]
    public virtual Provincia Provincias { get; set; } = null!;
}
