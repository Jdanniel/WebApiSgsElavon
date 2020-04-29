using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_UNIDADES")]
    public partial class BdUnidades
    {
        public BdUnidades()
        {
            BdBitacoraModeloUnidad = new HashSet<BdBitacoraModeloUnidad>();
            BdBitacoraPropiedadCliente = new HashSet<BdBitacoraPropiedadCliente>();
            BdBitacoraUnidad = new HashSet<BdBitacoraUnidad>();
            BdBitacoraUnidadDanada = new HashSet<BdBitacoraUnidadDanada>();
            BdDevoluciones = new HashSet<BdDevoluciones>();
            BdEnvioUnidad = new HashSet<BdEnvioUnidad>();
            BdInstalacionesIdParentNavigation = new HashSet<BdInstalaciones>();
            BdInstalacionesIdUnidadNavigation = new HashSet<BdInstalaciones>();
            BdMcSims = new HashSet<BdMcSims>();
            BdReingresoSim = new HashSet<BdReingresoSim>();
            BdReingresoUnidad = new HashSet<BdReingresoUnidad>();
            BdRetirosIdParentNavigation = new HashSet<BdRetiros>();
            BdRetirosIdUnidadNavigation = new HashSet<BdRetiros>();
            BdSolicitudesDevolucionUnidad = new HashSet<BdSolicitudesDevolucionUnidad>();
            BdSustitucionesIdUnidadEntradaNavigation = new HashSet<BdSustituciones>();
            BdSustitucionesIdUnidadSalidaNavigation = new HashSet<BdSustituciones>();
            BdUnidadAccesorio = new HashSet<BdUnidadAccesorio>();
            ReporteHojaServicios = new HashSet<ReporteHojaServicios>();
        }

        [Key]
        [Column("ID_UNIDAD")]
        public int IdUnidad { get; set; }
        [Column("ID_PARENT")]
        public int? IdParent { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_SOLICITUD_RECOLECCION")]
        public int? IdSolicitudRecoleccion { get; set; }
        [Column("ID_PRODUCTO")]
        public int? IdProducto { get; set; }
        [Column("IS_NUEVA")]
        public int IsNueva { get; set; }
        [Column("ID_MARCA")]
        public int IdMarca { get; set; }
        [Column("ID_MODELO")]
        public int IdModelo { get; set; }
        [Required]
        [Column("NO_SERIE")]
        [StringLength(50)]
        public string NoSerie { get; set; }
        [Column("NO_INVENTARIO")]
        [StringLength(50)]
        public string NoInventario { get; set; }
        [Column("ID_SIM")]
        public int? IdSim { get; set; }
        [Column("NO_IMEI")]
        [StringLength(50)]
        public string NoImei { get; set; }
        [Column("NO_SIM")]
        [StringLength(50)]
        public string NoSim { get; set; }
        [Column("NO_EQUIPO")]
        [StringLength(50)]
        public string NoEquipo { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int IdTipoResponsable { get; set; }
        [Column("ID_RESPONSABLE")]
        public int IdResponsable { get; set; }
        [Column("ID_LLAVE")]
        public int? IdLlave { get; set; }
        [Column("ID_SOFTWARE")]
        public int? IdSoftware { get; set; }
        [Column("POSICION_INVENTARIO")]
        [StringLength(50)]
        public string PosicionInventario { get; set; }
        [Column("IS_RETIRO")]
        public int? IsRetiro { get; set; }
        [Column("IS_DANIADA")]
        public int? IsDaniada { get; set; }
        [Column("COSTO", TypeName = "numeric(18, 2)")]
        public decimal? Costo { get; set; }
        [Column("ID_MONEDA")]
        public int? IdMoneda { get; set; }
        [Column("ID_STATUS_UNIDAD")]
        public int IdStatusUnidad { get; set; }
        [Column("ID_ITEMS_SOLICITUD_ALMACEN")]
        public int? IdItemsSolicitudAlmacen { get; set; }
        [Column("IS_PROPIEDAD_CLIENTE")]
        public int? IsPropiedadCliente { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("MOTIVO_ENVIADA_SCRAP")]
        [StringLength(255)]
        public string MotivoEnviadaScrap { get; set; }
        [Column("ID_TECNICO_ENVIADA_SCRAP")]
        public int? IdTecnicoEnviadaScrap { get; set; }
        [Column("ORDEN_COMPRA")]
        [StringLength(50)]
        public string OrdenCompra { get; set; }
        [Column("CAJA")]
        [StringLength(3)]
        public string Caja { get; set; }
        [Column("VERSION")]
        [StringLength(250)]
        public string Version { get; set; }
        [Column("ID_TIPO_CONEXION")]
        public int? IdTipoConexion { get; set; }
        [Column("ID_TIPO_TERMINAL")]
        public int? IdTipoTerminal { get; set; }
        [Column("ID_APLICATIVO")]
        public int? IdAplicativo { get; set; }
        [Column("ID_FABRICANTE")]
        public int? IdFabricante { get; set; }
        [Column("VERSION_KERNEL")]
        [StringLength(50)]
        public string VersionKernel { get; set; }
        [Column("FECHA_VENCIMIENTO_KERNEL", TypeName = "smalldatetime")]
        public DateTime? FechaVencimientoKernel { get; set; }
        [Column("purchase_order_no")]
        [StringLength(255)]
        public string PurchaseOrderNo { get; set; }
        [Column("ID_NIVEL_DIAGNOSTICO")]
        public int? IdNivelDiagnostico { get; set; }
        [Column("IS_DIAGNOSTICADA")]
        public int? IsDiagnosticada { get; set; }
        [Column("IS_DATO")]
        public int? IsDato { get; set; }
        [Column("IS_GARANTIA")]
        public int? IsGarantia { get; set; }
        [Column("COMENTARIOS")]
        public string Comentarios { get; set; }
        [Column("FOLIO_TELMEX")]
        [StringLength(20)]
        public string FolioTelmex { get; set; }
        [Column("NO_TARIMA")]
        [StringLength(50)]
        public string NoTarima { get; set; }
        [Column("FEC_INICIO", TypeName = "datetime")]
        public DateTime? FecInicio { get; set; }
        [Column("VIGENCIA", TypeName = "datetime")]
        public DateTime? Vigencia { get; set; }
        [Column("IS_INTERNACIONAL")]
        public int? IsInternacional { get; set; }
        [Column("IS_VENTA")]
        public int? IsVenta { get; set; }
        [Column("IS_FACTURABLE")]
        public int? IsFacturable { get; set; }
        [Column("ID_CONECTIVIDAD")]
        public int? IdConectividad { get; set; }
        [Column("ID_ORDEN_COMPRA")]
        public int? IdOrdenCompra { get; set; }

        [InverseProperty("IdUnidadNavigation")]
        public virtual ICollection<BdBitacoraModeloUnidad> BdBitacoraModeloUnidad { get; set; }
        [InverseProperty("IdUnidadNavigation")]
        public virtual ICollection<BdBitacoraPropiedadCliente> BdBitacoraPropiedadCliente { get; set; }
        [InverseProperty("IdUnidadNavigation")]
        public virtual ICollection<BdBitacoraUnidad> BdBitacoraUnidad { get; set; }
        [InverseProperty("IdUnidadNavigation")]
        public virtual ICollection<BdBitacoraUnidadDanada> BdBitacoraUnidadDanada { get; set; }
        [InverseProperty("IdUnidadNavigation")]
        public virtual ICollection<BdDevoluciones> BdDevoluciones { get; set; }
        [InverseProperty("IdUnidadNavigation")]
        public virtual ICollection<BdEnvioUnidad> BdEnvioUnidad { get; set; }
        [InverseProperty("IdParentNavigation")]
        public virtual ICollection<BdInstalaciones> BdInstalacionesIdParentNavigation { get; set; }
        [InverseProperty("IdUnidadNavigation")]
        public virtual ICollection<BdInstalaciones> BdInstalacionesIdUnidadNavigation { get; set; }
        [InverseProperty("IdUnidadNavigation")]
        public virtual ICollection<BdMcSims> BdMcSims { get; set; }
        [InverseProperty("IdUnidadNavigation")]
        public virtual ICollection<BdReingresoSim> BdReingresoSim { get; set; }
        [InverseProperty("IdUnidadNavigation")]
        public virtual ICollection<BdReingresoUnidad> BdReingresoUnidad { get; set; }
        [InverseProperty("IdParentNavigation")]
        public virtual ICollection<BdRetiros> BdRetirosIdParentNavigation { get; set; }
        [InverseProperty("IdUnidadNavigation")]
        public virtual ICollection<BdRetiros> BdRetirosIdUnidadNavigation { get; set; }
        [InverseProperty("IdUnidadNavigation")]
        public virtual ICollection<BdSolicitudesDevolucionUnidad> BdSolicitudesDevolucionUnidad { get; set; }
        [InverseProperty("IdUnidadEntradaNavigation")]
        public virtual ICollection<BdSustituciones> BdSustitucionesIdUnidadEntradaNavigation { get; set; }
        [InverseProperty("IdUnidadSalidaNavigation")]
        public virtual ICollection<BdSustituciones> BdSustitucionesIdUnidadSalidaNavigation { get; set; }
        [InverseProperty("IdUnidadNavigation")]
        public virtual ICollection<BdUnidadAccesorio> BdUnidadAccesorio { get; set; }
        [InverseProperty("IdUnidadNavigation")]
        public virtual ICollection<ReporteHojaServicios> ReporteHojaServicios { get; set; }
    }
}
