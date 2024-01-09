using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdSolicitudAlmacenComentario
{
    public int IdComentarioSolicitudAlmacen { get; set; }

    public int? IdSolicitudAlmacen { get; set; }

    public string DescComentarioSolicitudAlmacen { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdStatusSolicitudAlmacen { get; set; }
}
