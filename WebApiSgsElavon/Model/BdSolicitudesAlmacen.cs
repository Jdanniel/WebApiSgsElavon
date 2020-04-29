using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUDES_ALMACEN")]
    public partial class BdSolicitudesAlmacen
    {
        [Key]
        [Column("ID_SOLICITUD_ALMACEN")]
        public int IdSolicitudAlmacen { get; set; }
        [Column("ID_ALMACEN")]
        public int IdAlmacen { get; set; }
        [Column("ID_TIPO_SOLICITUD_ALMACEN")]
        public int IdTipoSolicitudAlmacen { get; set; }
        [Column("ID_URGENCIA_SOLICITUD_ALMACEN")]
        public int IdUrgenciaSolicitudAlmacen { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_STATUS_SOLICITUD_ALMACEN")]
        public int? IdStatusSolicitudAlmacen { get; set; }
        [Column("ID_MARCA")]
        public int? IdMarca { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("ID_SPARE_PART")]
        public int? IdSparePart { get; set; }
        [Column("CANTIDAD_SPARE_PART")]
        public int? CantidadSparePart { get; set; }
        [Column("NOTAS")]
        [StringLength(512)]
        public string Notas { get; set; }
        [Column("ID_TIPO_RESPONSABLE_DESTINO")]
        public int IdTipoResponsableDestino { get; set; }
        [Column("ID_RESPONSABLE_DESTINO")]
        public int IdResponsableDestino { get; set; }
        [Column("ID_DIRECCION")]
        public int? IdDireccion { get; set; }
        [Column("OTRA_DIRECCION")]
        [StringLength(255)]
        public string OtraDireccion { get; set; }
        [Column("FEC_COMPROMISO", TypeName = "smalldatetime")]
        public DateTime? FecCompromiso { get; set; }
        [Column("ID_TIPO_SERVICIO")]
        public int IdTipoServicio { get; set; }
        [Column("IS_ENTREGAS_PARCIALES")]
        public int IsEntregasParciales { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Column("ID_USUARIO_CONFIRM")]
        public int? IdUsuarioConfirm { get; set; }
        [Column("FEC_CONFIRM", TypeName = "smalldatetime")]
        public DateTime? FecConfirm { get; set; }
        [Column("ID_ENVIO")]
        public int? IdEnvio { get; set; }

        [ForeignKey("IdDireccion")]
        [InverseProperty("BdSolicitudesAlmacen")]
        public virtual BdDirecciones IdDireccionNavigation { get; set; }
        [ForeignKey("IdSparePart")]
        [InverseProperty("BdSolicitudesAlmacen")]
        public virtual CSpareParts IdSparePartNavigation { get; set; }
        [ForeignKey("IdTipoResponsableDestino")]
        [InverseProperty("BdSolicitudesAlmacen")]
        public virtual CTipoResponsable IdTipoResponsableDestinoNavigation { get; set; }
        [ForeignKey("IdTipoServicio")]
        [InverseProperty("BdSolicitudesAlmacen")]
        public virtual CTipoServicioSolicitudAlmacen IdTipoServicioNavigation { get; set; }
        [ForeignKey("IdTipoSolicitudAlmacen")]
        [InverseProperty("BdSolicitudesAlmacen")]
        public virtual CTipoSolicitudAlmacen IdTipoSolicitudAlmacenNavigation { get; set; }
        [ForeignKey("IdUrgenciaSolicitudAlmacen")]
        [InverseProperty("BdSolicitudesAlmacen")]
        public virtual CUrgenciaSolicitudAlmacen IdUrgenciaSolicitudAlmacenNavigation { get; set; }
    }
}
