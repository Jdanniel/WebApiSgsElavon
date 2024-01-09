using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdIngresoArchivosAlmacen
{
    public int IdArchivoAlmacen { get; set; }

    public int? IdArchivo { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdCliente { get; set; }

    public int? IdModelo { get; set; }

    public int? IdMarca { get; set; }

    public string Serie { get; set; }

    public string NoSim { get; set; }

    public string NoImei { get; set; }

    public int? IdCarrier { get; set; }

    public DateTime? FechaCompra { get; set; }

    public int? IdTipoConexion { get; set; }

    public int? IdTipoTerminal { get; set; }

    public int? IdAplicativo { get; set; }

    public int? Categoria { get; set; }

    public int? IdFabricante { get; set; }

    public string VersionAplicativo { get; set; }

    public string VersionKernel { get; set; }

    public DateTime? FechaVencimientoKernel { get; set; }

    public string StatusArchivo { get; set; }

    public int? IdUsuarioAltaArchivo { get; set; }

    public DateTime? FechaAltaArchivo { get; set; }

    public string DescError { get; set; }

    public int? IsSim { get; set; }

    public int? IdTipoResponsableDestino { get; set; }

    public int? IdResponsableDestino { get; set; }

    public int? IdConectividad { get; set; }
}
