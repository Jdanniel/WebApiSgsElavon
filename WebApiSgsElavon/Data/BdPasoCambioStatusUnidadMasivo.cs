using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdPasoCambioStatusUnidadMasivo
{
    public int IdPasoCambioStatusUnidadMasivo { get; set; }

    public string NoSerie { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdStatusUnidad { get; set; }

    public int? IdCarga { get; set; }

    public DateTime? FecCarga { get; set; }

    public int? IdUsuarioCarga { get; set; }

    public string Validacion { get; set; }

    public string Comentario { get; set; }
}
