using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdLogro
{
    public int IdLogro { get; set; }

    public DateTime? FecRealCierre { get; set; }

    public int? IdGerente { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdArea { get; set; }

    public int? IdTipoLogro { get; set; }

    public string DescLogro { get; set; }

    public string Cuantificacion { get; set; }

    public DateTime? FecAuditable { get; set; }

    public string Comentario { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string Status { get; set; }
}
