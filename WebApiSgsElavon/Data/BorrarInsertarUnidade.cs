using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BorrarInsertarUnidade
{
    public int IdUnidad { get; set; }

    public int? IdParent { get; set; }

    public int IdCliente { get; set; }

    public int? IdSolicitudRecoleccion { get; set; }

    public int? IdProducto { get; set; }

    public int IsNueva { get; set; }

    public int IdMarca { get; set; }

    public int IdModelo { get; set; }

    public string NoSerie { get; set; }

    public string NoInventario { get; set; }

    public int? IdSim { get; set; }

    public string NoImei { get; set; }

    public string NoSim { get; set; }

    public string NoEquipo { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdLlave { get; set; }

    public int? IdSoftware { get; set; }

    public string PosicionInventario { get; set; }

    public int? IsRetiro { get; set; }

    public int? IsDaniada { get; set; }

    public decimal? Costo { get; set; }

    public int? IdMoneda { get; set; }

    public int IdStatusUnidad { get; set; }

    public int? IdItemsSolicitudAlmacen { get; set; }

    public int? IsPropiedadCliente { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string MotivoEnviadaScrap { get; set; }

    public int? IdTecnicoEnviadaScrap { get; set; }

    public string OrdenCompra { get; set; }

    public string Caja { get; set; }

    public string Version { get; set; }

    public int? IdTipoConexion { get; set; }

    public int? IdTipoTerminal { get; set; }

    public int? IdAplicativo { get; set; }

    public int? IdFabricante { get; set; }

    public string VersionKernel { get; set; }

    public DateTime? FechaVencimientoKernel { get; set; }

    public string PurchaseOrderNo { get; set; }

    public int? IdNivelDiagnostico { get; set; }

    public int? IsDiagnosticada { get; set; }

    public int? IsDato { get; set; }

    public int? IsGarantia { get; set; }

    public string Comentarios { get; set; }

    public string FolioTelmex { get; set; }

    public string NoTarima { get; set; }

    public DateTime? FecInicio { get; set; }

    public DateTime? Vigencia { get; set; }

    public int? IsInternacional { get; set; }

    public int? IsVenta { get; set; }

    public int? IsFacturable { get; set; }

    public int? IdConectividad { get; set; }

    public int? IdOrdenCompra { get; set; }
}
