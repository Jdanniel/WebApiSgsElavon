using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUDES_VIATICOS")]
    public partial class BdSolicitudesViaticos
    {
        public BdSolicitudesViaticos()
        {
            BdArchivoDispersionSolicitudViaticos = new HashSet<BdArchivoDispersionSolicitudViaticos>();
            BdBitacoraSolicitudesViaticos = new HashSet<BdBitacoraSolicitudesViaticos>();
            BdConfirmaciones = new HashSet<BdConfirmaciones>();
            BdConfirmacionesIntermedia = new HashSet<BdConfirmacionesIntermedia>();
            BdSolicitudesViaticosConceptos = new HashSet<BdSolicitudesViaticosConceptos>();
        }

        [Column("ID_SOLICITUD_VIATICOS")]
        public int IdSolicitudViaticos { get; set; }
        [Column("ID_STATUS_SOLICITUD_VIATICOS")]
        public int IdStatusSolicitudViaticos { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Required]
        [Column("DESTINO")]
        [StringLength(100)]
        public string Destino { get; set; }
        [Column("COMENTARIO_SOLICITANTE")]
        [StringLength(500)]
        public string ComentarioSolicitante { get; set; }
        [Column("COMENTARIO_AUTORIZADOR")]
        [StringLength(500)]
        public string ComentarioAutorizador { get; set; }
        [Column("COMENTARIO_CONFIRMADOR")]
        [StringLength(500)]
        public string ComentarioConfirmador { get; set; }
        [Column("ID_CUENTA_BANCARIA")]
        public int? IdCuentaBancaria { get; set; }
        [Column("NUM_CONFIRMACION")]
        [StringLength(50)]
        public string NumConfirmacion { get; set; }
        [Column("FEC_CONFIRMACION", TypeName = "smalldatetime")]
        public DateTime? FecConfirmacion { get; set; }
        [Column("ID_USUARIO_SOLICITADO")]
        public int? IdUsuarioSolicitado { get; set; }
        [Column("ID_COMPROBACION_SOLICITUDES_VIATICOS")]
        public int? IdComprobacionSolicitudesViaticos { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Column("FROM_AUTOMATIZACION")]
        public int? FromAutomatizacion { get; set; }

        [ForeignKey("IdStatusSolicitudViaticos")]
        [InverseProperty("BdSolicitudesViaticos")]
        public virtual CStatusSolicitudViaticos IdStatusSolicitudViaticosNavigation { get; set; }
        [InverseProperty("IdSolicitudViaticosNavigation")]
        public virtual ICollection<BdArchivoDispersionSolicitudViaticos> BdArchivoDispersionSolicitudViaticos { get; set; }
        [InverseProperty("IdSolicitudViaticosNavigation")]
        public virtual ICollection<BdBitacoraSolicitudesViaticos> BdBitacoraSolicitudesViaticos { get; set; }
        [InverseProperty("IdSolicitudViaticosNavigation")]
        public virtual ICollection<BdConfirmaciones> BdConfirmaciones { get; set; }
        [InverseProperty("IdSolicitudViaticosNavigation")]
        public virtual ICollection<BdConfirmacionesIntermedia> BdConfirmacionesIntermedia { get; set; }
        [InverseProperty("IdSolicitudViaticosNavigation")]
        public virtual ICollection<BdSolicitudesViaticosConceptos> BdSolicitudesViaticosConceptos { get; set; }
    }
}
