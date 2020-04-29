using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUD_RECOLECCION")]
    public partial class BdSolicitudRecoleccion
    {
        public BdSolicitudRecoleccion()
        {
            BdBitacoraSolicitudRecoleccion = new HashSet<BdBitacoraSolicitudRecoleccion>();
            BdReingresoSimIdSolicitudRecoleccionAnteriorNavigation = new HashSet<BdReingresoSim>();
            BdReingresoSimIdSolicitudRecoleccionReingresoNavigation = new HashSet<BdReingresoSim>();
            BdReingresoUnidadIdSolicitudRecoleccionAnteriorNavigation = new HashSet<BdReingresoUnidad>();
            BdReingresoUnidadIdSolicitudRecoleccionReingresoNavigation = new HashSet<BdReingresoUnidad>();
            BdSolicitudRecoleccionInsumos = new HashSet<BdSolicitudRecoleccionInsumos>();
            BdSolicitudRecoleccionModelo = new HashSet<BdSolicitudRecoleccionModelo>();
        }

        [Column("ID_SOLICITUD_RECOLECCION")]
        public int IdSolicitudRecoleccion { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_ALMACEN_DESTINO")]
        public int? IdAlmacenDestino { get; set; }
        [Column("DISTRIBUIDOR")]
        [StringLength(50)]
        public string Distribuidor { get; set; }
        [Column("NO_UNIDADES")]
        public int? NoUnidades { get; set; }
        [Column("ID_SERVICIO_MENSAJERIA")]
        public int? IdServicioMensajeria { get; set; }
        [Column("CALLE_NUM")]
        [StringLength(80)]
        public string CalleNum { get; set; }
        [Column("COLONIA")]
        [StringLength(60)]
        public string Colonia { get; set; }
        [Column("DELEGACION")]
        [StringLength(60)]
        public string Delegacion { get; set; }
        [Column("CIUDAD")]
        [StringLength(60)]
        public string Ciudad { get; set; }
        [Column("ESTADO")]
        [StringLength(60)]
        public string Estado { get; set; }
        [Column("CP")]
        [StringLength(5)]
        public string Cp { get; set; }
        [Column("FEC_RECOLECCION", TypeName = "smalldatetime")]
        public DateTime? FecRecoleccion { get; set; }
        [Column("HORA_RECOLECCION", TypeName = "datetime")]
        public DateTime? HoraRecoleccion { get; set; }
        [Column("ID_UNIDAD_MENSAJERIA")]
        public int? IdUnidadMensajeria { get; set; }
        [Column("ID_CHOFER")]
        public int? IdChofer { get; set; }
        [Column("ID_STATUS_SOLICITUD_RECOLECCION")]
        public int? IdStatusSolicitudRecoleccion { get; set; }
        [Column("ID_ATTACH_SOLICITUD")]
        public int? IdAttachSolicitud { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_TIPO_SOLICITUD")]
        public int? IdTipoSolicitud { get; set; }
        [Column("CANTIDADES")]
        public int? Cantidades { get; set; }

        [ForeignKey("IdChofer")]
        [InverseProperty("BdSolicitudRecoleccion")]
        public virtual CChoferes IdChoferNavigation { get; set; }
        [ForeignKey("IdStatusSolicitudRecoleccion")]
        [InverseProperty("BdSolicitudRecoleccion")]
        public virtual CStatusSolicitudRecoleccion IdStatusSolicitudRecoleccionNavigation { get; set; }
        [ForeignKey("IdUnidadMensajeria")]
        [InverseProperty("BdSolicitudRecoleccion")]
        public virtual CUnidadMensajeria IdUnidadMensajeriaNavigation { get; set; }
        [InverseProperty("IdSolicitudRecoleccionNavigation")]
        public virtual ICollection<BdBitacoraSolicitudRecoleccion> BdBitacoraSolicitudRecoleccion { get; set; }
        [InverseProperty("IdSolicitudRecoleccionAnteriorNavigation")]
        public virtual ICollection<BdReingresoSim> BdReingresoSimIdSolicitudRecoleccionAnteriorNavigation { get; set; }
        [InverseProperty("IdSolicitudRecoleccionReingresoNavigation")]
        public virtual ICollection<BdReingresoSim> BdReingresoSimIdSolicitudRecoleccionReingresoNavigation { get; set; }
        [InverseProperty("IdSolicitudRecoleccionAnteriorNavigation")]
        public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdSolicitudRecoleccionAnteriorNavigation { get; set; }
        [InverseProperty("IdSolicitudRecoleccionReingresoNavigation")]
        public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdSolicitudRecoleccionReingresoNavigation { get; set; }
        [InverseProperty("IdSolicitudRecoleccionNavigation")]
        public virtual ICollection<BdSolicitudRecoleccionInsumos> BdSolicitudRecoleccionInsumos { get; set; }
        [InverseProperty("IdSolicitudRecoleccionNavigation")]
        public virtual ICollection<BdSolicitudRecoleccionModelo> BdSolicitudRecoleccionModelo { get; set; }
    }
}
