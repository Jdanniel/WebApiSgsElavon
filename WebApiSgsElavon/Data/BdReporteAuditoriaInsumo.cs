using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdReporteAuditoriaInsumo
{
    public int IdReporteAuditoriaInsumos { get; set; }

    public int? IdCliente { get; set; }

    public int? IdInsumo { get; set; }

    public int? TotalSistema { get; set; }

    public int? IdStatusInsumo { get; set; }

    public int? TotalIng { get; set; }

    public string ComentarioIncoformidad { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdAuditoria { get; set; }

    public string Status { get; set; }
}
