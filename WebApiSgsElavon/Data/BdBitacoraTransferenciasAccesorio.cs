using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraTransferenciasAccesorio
{
    public int IdBitacoraTransferenciasAccesorios { get; set; }

    public int? IdAccesorio { get; set; }

    public int? Cantidad { get; set; }

    public int? IdTipoResponsableOrigen { get; set; }

    public int? IdResponsableOrigen { get; set; }

    public int? IdTipoResponsableDestino { get; set; }

    public int? IdResponsableDestino { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Comentarios { get; set; }
}
