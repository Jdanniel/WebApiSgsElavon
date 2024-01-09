using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdTemplatesMailjet
{
    public int IdTemplateMailjet { get; set; }

    public int? IdMailjet { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public string RutaArchivo { get; set; }

    public string NombreArchivo { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdTipoPlantilla { get; set; }

    public string AsuntoEmail { get; set; }

    public bool Status { get; set; }
}
