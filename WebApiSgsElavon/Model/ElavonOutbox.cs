using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("ELAVON_OUTBOX")]
    public partial class ElavonOutbox
    {
        [Key]
        [Column("ID_ELAVON_OUTBOX")]
        public int IdElavonOutbox { get; set; }
        [Column("ID_ENVIO_ELAVON")]
        public int? IdEnvioElavon { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(250)]
        public string Status { get; set; }
        [Column("request_id")]
        [StringLength(250)]
        public string RequestId { get; set; }
        [Column("request_status")]
        [StringLength(250)]
        public string RequestStatus { get; set; }
        [Column("status_reason_code")]
        [StringLength(250)]
        public string StatusReasonCode { get; set; }
        [Column("status_reason")]
        [StringLength(250)]
        public string StatusReason { get; set; }
        [Column("comments")]
        [StringLength(250)]
        public string Comments { get; set; }
        [Column("booking_dt")]
        [StringLength(250)]
        public string BookingDt { get; set; }
        [Column("service_received_by")]
        [StringLength(250)]
        public string ServiceReceivedBy { get; set; }
        [Column("mid")]
        [StringLength(250)]
        public string Mid { get; set; }
        [Column("tid")]
        [StringLength(250)]
        public string Tid { get; set; }
        [Column("serial")]
        [StringLength(250)]
        public string Serial { get; set; }
        [Column("device_type_category")]
        [StringLength(250)]
        public string DeviceTypeCategory { get; set; }
        [Column("device_type")]
        [StringLength(250)]
        public string DeviceType { get; set; }
        [Column("assignment_no_from")]
        [StringLength(250)]
        public string AssignmentNoFrom { get; set; }
        [Column("assignment_no")]
        [StringLength(250)]
        public string AssignmentNo { get; set; }
        [Column("purchase_order_no")]
        [StringLength(250)]
        public string PurchaseOrderNo { get; set; }
        [Column("profile")]
        [StringLength(250)]
        public string Profile { get; set; }
        [Column("CABECERA")]
        [StringLength(250)]
        public string Cabecera { get; set; }
    }
}
