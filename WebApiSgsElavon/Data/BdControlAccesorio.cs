using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdControlAccesorio
{
    public int IdControlAccesorios { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdAccesorio { get; set; }

    public int? IdStatusOrdenCompraAccesorio { get; set; }

    public int? Entrada { get; set; }

    public int? Salida { get; set; }

    public int? Total { get; set; }

    public int? IdControlAccesoriosEntradaSalida { get; set; }
}
