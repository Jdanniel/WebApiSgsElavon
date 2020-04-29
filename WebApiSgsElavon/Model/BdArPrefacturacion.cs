using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_PREFACTURACION")]
    public partial class BdArPrefacturacion
    {
        [Key]
        [Column("ID_AR_PREFACTURACION")]
        public int IdArPrefacturacion { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_TAREA")]
        public int? IdTarea { get; set; }
        [Column("ID_BITACORA_AGENDADO")]
        public int? IdBitacoraAgendado { get; set; }
        [Column("ID_STATUS_AR_PREFACTURACION")]
        public int? IdStatusArPrefacturacion { get; set; }
        [Column("ID_TIPO_RESPONSABLE_DOCTO_PREFACTURACION_FISICO")]
        public int? IdTipoResponsableDoctoPrefacturacionFisico { get; set; }
        [Column("ID_RESPONSABLE_DOCTO_PREFACTURACION_FISICO")]
        public int? IdResponsableDoctoPrefacturacionFisico { get; set; }
        [Column("ID_STATUS_DOCTO_PREFACTURACION_FISICO")]
        public int? IdStatusDoctoPrefacturacionFisico { get; set; }
        [Column("ID_TIPO_RESPONSABLE_DOCTO_PREFACTURACION_DIGITAL")]
        public int? IdTipoResponsableDoctoPrefacturacionDigital { get; set; }
        [Column("ID_RESPONSABLE_DOCTO_PREFACTURACION_DIGITAL")]
        public int? IdResponsableDoctoPrefacturacionDigital { get; set; }
        [Column("ID_STATUS_DOCTO_PREFACTURACION_DIGITAL")]
        public int? IdStatusDoctoPrefacturacionDigital { get; set; }
        [Column("COUNTER")]
        public int? Counter { get; set; }
        [Column("ID_CAUSA_RECHAZO_DEFINITIVO_DOCTO_PREFACTURACION")]
        public int? IdCausaRechazoDefinitivoDoctoPrefacturacion { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("FEC_STATUS", TypeName = "smalldatetime")]
        public DateTime? FecStatus { get; set; }
        [Column("ID_USUARIO_STATUS")]
        public int? IdUsuarioStatus { get; set; }
    }
}
