using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CZonaAtencionSantander
{
    public int IdZonaAtencion { get; set; }

    public int IdZona { get; set; }

    public int IdRegion { get; set; }

    public string CentroServicio { get; set; }

    public string Estado { get; set; }

    public string Region { get; set; }

    public string Responsable { get; set; }

    public int? ZonaMf { get; set; }
}
