using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraInstalacionRetiroMasivo
{
    public int IdBitacoraInstalacionRetiroMasivo { get; set; }

    public int? IdInstalacionRetirosMasivos { get; set; }

    public string Odt { get; set; }

    public string NoSerieEntrada { get; set; }

    public string NoSerieSimEntrada { get; set; }

    public int? IdInstalacion { get; set; }

    public int? IdInstalacionSim { get; set; }

    public string NoSerieSale { get; set; }

    public string NoSerieSimSale { get; set; }

    public int? IdRetiro { get; set; }

    public int? IdRetiroSim { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }
}
