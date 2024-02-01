using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraTransferencia
{
    public int IdBitacoraTransferencia { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdTipoResponsableAnterior { get; set; }

    public int? IdResponsableAnterior { get; set; }

    public int? IdTipoResponsableActual { get; set; }

    public int? IdResponsableActual { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Comentarios { get; set; }
}
