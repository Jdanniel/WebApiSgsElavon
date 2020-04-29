using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_REINGRESO_UNIDAD")]
    public partial class BdReingresoUnidad
    {
        [Key]
        [Column("ID_REINGRESO_UNIDAD")]
        public int IdReingresoUnidad { get; set; }
        [Column("ID_UNIDAD")]
        public int IdUnidad { get; set; }
        [Column("NO_SERIE_ANTERIOR")]
        [StringLength(50)]
        public string NoSerieAnterior { get; set; }
        [Column("NO_INVENTARIO_ANTERIOR")]
        [StringLength(50)]
        public string NoInventarioAnterior { get; set; }
        [Column("NO_SIM_ANTERIOR")]
        [StringLength(50)]
        public string NoSimAnterior { get; set; }
        [Column("NO_IMEI_ANTERIOR")]
        [StringLength(50)]
        public string NoImeiAnterior { get; set; }
        [Column("IS_NUEVA_ANTERIOR")]
        public int? IsNuevaAnterior { get; set; }
        [Column("IS_DANIADA_ANTERIOR")]
        public int? IsDaniadaAnterior { get; set; }
        [Column("ID_CLIENTE_ANTERIOR")]
        public int? IdClienteAnterior { get; set; }
        [Column("ID_STATUS_UNIDAD_ANTERIOR")]
        public int? IdStatusUnidadAnterior { get; set; }
        [Column("ID_TIPO_RESPONSABLE_ANTERIOR")]
        public int? IdTipoResponsableAnterior { get; set; }
        [Column("ID_RESPONSABLE_ANTERIOR")]
        public int? IdResponsableAnterior { get; set; }
        [Column("ID_SOLICITUD_RECOLECCION_ANTERIOR")]
        public int? IdSolicitudRecoleccionAnterior { get; set; }
        [Column("NO_SERIE_REINGRESO")]
        [StringLength(50)]
        public string NoSerieReingreso { get; set; }
        [Column("NO_INVENTARIO_REINGRESO")]
        [StringLength(50)]
        public string NoInventarioReingreso { get; set; }
        [Column("NO_SIM_REINGRESO")]
        [StringLength(50)]
        public string NoSimReingreso { get; set; }
        [Column("NO_IMEI_REINGRESO")]
        [StringLength(50)]
        public string NoImeiReingreso { get; set; }
        [Column("IS_NUEVA_REINGRESO")]
        public int? IsNuevaReingreso { get; set; }
        [Column("IS_DANIADA_REINGRESO")]
        public int? IsDaniadaReingreso { get; set; }
        [Column("ID_CLIENTE_REINGRESO")]
        public int? IdClienteReingreso { get; set; }
        [Column("ID_STATUS_UNIDAD_REINGRESO")]
        public int? IdStatusUnidadReingreso { get; set; }
        [Column("ID_TIPO_RESPONSABLE_REINGRESO")]
        public int? IdTipoResponsableReingreso { get; set; }
        [Column("ID_RESPONSABLE_REINGRESO")]
        public int? IdResponsableReingreso { get; set; }
        [Column("ID_SOLICITUD_RECOLECCION_REINGRESO")]
        public int? IdSolicitudRecoleccionReingreso { get; set; }
        [Column("FEC_REINGRESO", TypeName = "smalldatetime")]
        public DateTime? FecReingreso { get; set; }
        [Column("ID_USUARIO_REINGRESO")]
        public int? IdUsuarioReingreso { get; set; }
        [Column("ID_APLICATIVO")]
        public int? IdAplicativo { get; set; }
        [Column("ID_CONECTIVIDAD")]
        public int? IdConectividad { get; set; }

        [ForeignKey("IdSolicitudRecoleccionAnterior")]
        [InverseProperty("BdReingresoUnidadIdSolicitudRecoleccionAnteriorNavigation")]
        public virtual BdSolicitudRecoleccion IdSolicitudRecoleccionAnteriorNavigation { get; set; }
        [ForeignKey("IdSolicitudRecoleccionReingreso")]
        [InverseProperty("BdReingresoUnidadIdSolicitudRecoleccionReingresoNavigation")]
        public virtual BdSolicitudRecoleccion IdSolicitudRecoleccionReingresoNavigation { get; set; }
        [ForeignKey("IdStatusUnidadAnterior")]
        [InverseProperty("BdReingresoUnidadIdStatusUnidadAnteriorNavigation")]
        public virtual CStatusUnidad IdStatusUnidadAnteriorNavigation { get; set; }
        [ForeignKey("IdStatusUnidadReingreso")]
        [InverseProperty("BdReingresoUnidadIdStatusUnidadReingresoNavigation")]
        public virtual CStatusUnidad IdStatusUnidadReingresoNavigation { get; set; }
        [ForeignKey("IdTipoResponsableAnterior")]
        [InverseProperty("BdReingresoUnidadIdTipoResponsableAnteriorNavigation")]
        public virtual CTipoResponsable IdTipoResponsableAnteriorNavigation { get; set; }
        [ForeignKey("IdTipoResponsableReingreso")]
        [InverseProperty("BdReingresoUnidadIdTipoResponsableReingresoNavigation")]
        public virtual CTipoResponsable IdTipoResponsableReingresoNavigation { get; set; }
        [ForeignKey("IdUnidad")]
        [InverseProperty("BdReingresoUnidad")]
        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}
