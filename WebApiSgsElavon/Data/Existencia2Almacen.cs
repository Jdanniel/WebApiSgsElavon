using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class Existencia2Almacen
{
    public string NoGuia { get; set; }

    public int? IdSolicitudAlmacen { get; set; }

    public string Cliente { get; set; }

    public string RegionOrigen { get; set; }

    public string ResponsableOrigen { get; set; }

    public string RegionDestino { get; set; }

    public string ResponsableDestino { get; set; }

    public string EstatusEnvio { get; set; }

    public int IdEnvio { get; set; }
}
