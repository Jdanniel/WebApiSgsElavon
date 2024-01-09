using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdIngresoArchivoInsumo
{
    public int IdIngresoArchivoInsumo { get; set; }

    public int? IdArchivo { get; set; }

    public int? IdCliente { get; set; }

    public int? IdInsumo { get; set; }

    public int? Cantidad { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdStatusInsumo { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string StatusArchivo { get; set; }

    public string DescError { get; set; }
}
