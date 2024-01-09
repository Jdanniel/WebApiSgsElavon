using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class RespaldoTabla
{
    public int IdReporteAuditoriaUnidad { get; set; }

    public int? IdUnidad { get; set; }

    public string NoSerie { get; set; }

    public string Producto { get; set; }

    public int? IdCliente { get; set; }

    public string Marca { get; set; }

    public int? IdModelo { get; set; }

    public string Conectividad { get; set; }

    public string Aplicativo { get; set; }

    public int? Daniada { get; set; }

    public DateTime? Fecha { get; set; }

    public int? IdUsuario { get; set; }

    public int? IsConfirmacion { get; set; }

    public string ComentarioIncoformidad { get; set; }

    public int? IdStatusUnidad { get; set; }

    public int? IdFisico { get; set; }

    public int? IdRazon { get; set; }

    public int? IdAuditoria { get; set; }
}
