using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdTransferenciasUnidad
{
    public int IdTransferenciaUnidad { get; set; }

    public int? IdTransferencia { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdTipoResponsableOrigen { get; set; }

    public int? IdResponsableOrigen { get; set; }

    public int? IdTipoResponsableDestino { get; set; }

    public int? IdResponsableDestino { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IsRecibido { get; set; }

    public DateTime? FecRecibido { get; set; }
}
