using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraDoctosPrefacturacion
{
    public int IdBitacoraDoctosPrefacturacion { get; set; }

    public int? IdArPrefacturacion { get; set; }

    public int? IdTipoDoctoPrefacturacion { get; set; }

    public string IdTipoResponsablePrefacturacion { get; set; }

    public int? IdResponsablePrefacturacion { get; set; }

    public int? IdStatusDoctoPrefacturacionIni { get; set; }

    public int? IdStatusDoctoPrefacturacionFin { get; set; }

    public string Comentario { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
