using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUDES_ALMACEN_OLD")]
    public partial class BdSolicitudesAlmacenOld
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
        public int IdAr { get; set; }
        [Column("ID_STATUS_SOLICITUD_ALMACEN")]
        public int IdStatusSolicitudAlmacen { get; set; }
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
        [StringLength(400)]
        public string Notas { get; set; }
        [Column("ID_TIPO_RESPONSABLE_DESTINO")]
        public int IdTipoResponsableDestino { get; set; }
        [Column("ID_RESPONSABLE_DESTINO")]
        public int IdResponsableDestino { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Column("ID_USUARIO_CONFIRM")]
        public int? IdUsuarioConfirm { get; set; }
        [Column("FEC_CONFIRM", TypeName = "smalldatetime")]
        public DateTime? FecConfirm { get; set; }

        [ForeignKey("IdAlmacen")]
        [InverseProperty("BdSolicitudesAlmacenOld")]
        public virtual CAlmacenes IdAlmacenNavigation { get; set; }
        [ForeignKey("IdResponsableDestino")]
        [InverseProperty("BdSolicitudesAlmacenOldIdResponsableDestinoNavigation")]
        public virtual CUsuarios IdResponsableDestinoNavigation { get; set; }
        [ForeignKey("IdSparePart")]
        [InverseProperty("BdSolicitudesAlmacenOld")]
        public virtual CSpareParts IdSparePartNavigation { get; set; }
        [ForeignKey("IdTipoResponsableDestino")]
        [InverseProperty("BdSolicitudesAlmacenOld")]
        public virtual CTipoResponsable IdTipoResponsableDestinoNavigation { get; set; }
        [ForeignKey("IdTipoSolicitudAlmacen")]
        [InverseProperty("BdSolicitudesAlmacenOld")]
        public virtual CTipoSolicitudAlmacen IdTipoSolicitudAlmacenNavigation { get; set; }
        [ForeignKey("IdUrgenciaSolicitudAlmacen")]
        [InverseProperty("BdSolicitudesAlmacenOld")]
        public virtual CUrgenciaSolicitudAlmacen IdUrgenciaSolicitudAlmacenNavigation { get; set; }
        [ForeignKey("IdUsuarioAlta")]
        [InverseProperty("BdSolicitudesAlmacenOldIdUsuarioAltaNavigation")]
        public virtual CUsuarios IdUsuarioAltaNavigation { get; set; }
        [ForeignKey("IdUsuarioConfirm")]
        [InverseProperty("BdSolicitudesAlmacenOldIdUsuarioConfirmNavigation")]
        public virtual CUsuarios IdUsuarioConfirmNavigation { get; set; }
    }
}
