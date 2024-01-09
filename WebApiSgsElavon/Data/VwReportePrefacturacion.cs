using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class VwReportePrefacturacion
{
    public int IdAr { get; set; }

    public int IdArPrefacturacion { get; set; }

    public string NoAfiliacion { get; set; }

    public string NoRepCliente { get; set; }

    public string NoTicketGasper { get; set; }

    public string NoReporteProveedor { get; set; }

    public string DescNegocio { get; set; }

    public string Direccion { get; set; }

    public string Colonia { get; set; }

    public string Cp { get; set; }

    public string Poblacion { get; set; }

    public string Estado { get; set; }

    public string FecCierreAgendado { get; set; }

    public string NoSerie { get; set; }

    public string DescModelo { get; set; }

    public string TipoServicio { get; set; }

    public string FolioValidacion { get; set; }

    public string DescripcionTrabajo { get; set; }

    public string CadenaCierre { get; set; }

    public string IsVisitaAgendado { get; set; }

    public int? NoVisita { get; set; }

    public string DescResponsableAgendado { get; set; }

    public string Comentario { get; set; }

    public string UsoPartes { get; set; }

    public string NombreArchivo { get; set; }

    public DateTime? FecAlta { get; set; }

    public int IdCliente { get; set; }

    public int? IdStatusDoctoPrefacturacionDigital { get; set; }

    public string Status { get; set; }

    public int? IdTecnico { get; set; }

    public int? IdZona { get; set; }

    public int? IdProducto { get; set; }
}
