﻿using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempNegocio
{
    public int Id { get; set; }

    public string NoAfiliacion { get; set; }

    public string DescNegocio { get; set; }

    public string Direccion { get; set; }

    public string Colonia { get; set; }

    public string Poblacion { get; set; }

    public string Estado { get; set; }

    public string Cp { get; set; }

    public string Segmento { get; set; }

    public int? IdRegion { get; set; }

    public int? IdZona { get; set; }

    public int? IdSegmento { get; set; }

    public int? IdCliente { get; set; }

    public int? IsDuplicated { get; set; }

    public int? IdEstado { get; set; }
}
