using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class Existencia1Almacen
{
    public int IdEnvio { get; set; }

    public int? IdSolicitudAlmacen { get; set; }

    public string NoGuia { get; set; }

    public DateTime? FechaEnvio { get; set; }

    public string TipoResponsableDestino { get; set; }

    public string DescMensajeria { get; set; }

    public string TipoResponsableOrigen { get; set; }

    public string ResponsableDestino { get; set; }

    public string ResponsableOrigen { get; set; }

    public int? IdResponsableOrigen { get; set; }

    public int? IdTipoResponsableDestino { get; set; }

    public int? IdResponsableDestino { get; set; }

    public string RegionDestino { get; set; }

    public string ZonaDestino { get; set; }

    public string ZonaOrigen { get; set; }

    public string RegionOrigen { get; set; }

    public string EstatusEnvio { get; set; }

    public string FechaRecepcion { get; set; }

    public DateOnly? F2 { get; set; }

    public int? IdStatusEnvio { get; set; }

    public string NoSerie { get; set; }

    public string DescInsumo { get; set; }

    public int? Cantidad { get; set; }

    public string Orden { get; set; }

    public string Cliente { get; set; }

    public int? IdEnvio1 { get; set; }

    public string DescSparePart { get; set; }

    public int CantidadSparePart { get; set; }
}
