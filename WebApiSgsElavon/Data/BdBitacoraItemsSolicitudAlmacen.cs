using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraItemsSolicitudAlmacen
{
    public int IdBitacoraItemsSolicitudAlmacen { get; set; }

    public int? IdItemsSolicitudAlmacen { get; set; }

    public int? IdStatusItemsSolicitudAlmacenIni { get; set; }

    public int? IdStatusItemsSolicitudAlmacenFin { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Comentario { get; set; }
}
