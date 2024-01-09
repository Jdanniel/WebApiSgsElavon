using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdArPrefacturacion
{
    public int IdArPrefacturacion { get; set; }

    public int? IdAr { get; set; }

    public int? IdTarea { get; set; }

    public int? IdBitacoraAgendado { get; set; }

    public int? IdStatusArPrefacturacion { get; set; }

    public int? IdTipoResponsableDoctoPrefacturacionFisico { get; set; }

    public int? IdResponsableDoctoPrefacturacionFisico { get; set; }

    public int? IdStatusDoctoPrefacturacionFisico { get; set; }

    public int? IdTipoResponsableDoctoPrefacturacionDigital { get; set; }

    public int? IdResponsableDoctoPrefacturacionDigital { get; set; }

    public int? IdStatusDoctoPrefacturacionDigital { get; set; }

    public int? Counter { get; set; }

    public int? IdCausaRechazoDefinitivoDoctoPrefacturacion { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }

    public DateTime? FecStatus { get; set; }

    public int? IdUsuarioStatus { get; set; }
}
