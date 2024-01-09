using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdUnidadesProcesadasAlmacen
{
    public int IdUnidadProcesadaAlmacen { get; set; }

    public int? IdCarga { get; set; }

    public int? IdUnidad { get; set; }

    public string NoSerie { get; set; }

    public int? IdUsuario { get; set; }

    public string Status { get; set; }

    public string Success { get; set; }
}
