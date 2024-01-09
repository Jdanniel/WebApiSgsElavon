using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdEnvioDoctosDocto
{
    public int IdEnvioDoctosDocto { get; set; }

    public int? IdEnvioDoctos { get; set; }

    public int? IdArPrefacturacion { get; set; }

    public int? IdAr { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public int? IsRecibido { get; set; }

    public DateTime? FecRecepcion { get; set; }

    public int? IdUsuarioRecepcion { get; set; }
}
