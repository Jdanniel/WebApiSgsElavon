using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdAjustesInsumosPaso
{
    public int IdAjuste { get; set; }

    public int? IdBdInsumo { get; set; }

    public int? Entrada { get; set; }

    public int? SalidaAnterior { get; set; }

    public int? SalidaActual { get; set; }

    public int? Total { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdTipoResponsable { get; set; }

    public DateTime? FecAlta { get; set; }
}
