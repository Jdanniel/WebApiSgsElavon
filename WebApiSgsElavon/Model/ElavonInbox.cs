using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("ELAVON_INBOX")]
    public partial class ElavonInbox
    {
        [Key]
        [Column("ID_ELAVON_INBOX")]
        public int IdElavonInbox { get; set; }
        [Column("ID_RECEPCION_ELAVON")]
        public int? IdRecepcionElavon { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("request_id")]
        [StringLength(250)]
        public string RequestId { get; set; }
        [Column("request_type")]
        [StringLength(250)]
        public string RequestType { get; set; }
        [Column("tid")]
        [StringLength(250)]
        public string Tid { get; set; }
        [Column("mid")]
        [StringLength(250)]
        public string Mid { get; set; }
        [Column("address1")]
        [StringLength(250)]
        public string Address1 { get; set; }
        [Column("address2")]
        [StringLength(250)]
        public string Address2 { get; set; }
        [Column("address3")]
        [StringLength(250)]
        public string Address3 { get; set; }
        [Column("zip")]
        [StringLength(250)]
        public string Zip { get; set; }
        [Column("city")]
        [StringLength(250)]
        public string City { get; set; }
        [Column("county_district")]
        [StringLength(250)]
        public string CountyDistrict { get; set; }
        [Column("state_province")]
        [StringLength(250)]
        public string StateProvince { get; set; }
        [Column("country")]
        [StringLength(250)]
        public string Country { get; set; }
        [Column("contact")]
        [StringLength(250)]
        public string Contact { get; set; }
        [Column("phone1")]
        [StringLength(250)]
        public string Phone1 { get; set; }
        [Column("phone2")]
        [StringLength(250)]
        public string Phone2 { get; set; }
        [Column("comments")]
        [StringLength(250)]
        public string Comments { get; set; }
        [Column("due_by")]
        [StringLength(250)]
        public string DueBy { get; set; }
        [Column("terminal_3_digit_number")]
        [StringLength(250)]
        public string Terminal3DigitNumber { get; set; }
        [Column("colony")]
        [StringLength(250)]
        public string Colony { get; set; }
        [Column("attention_window")]
        [StringLength(250)]
        public string AttentionWindow { get; set; }
        [Column("serial")]
        [StringLength(250)]
        public string Serial { get; set; }
        [Column("purchase_type")]
        [StringLength(250)]
        public string PurchaseType { get; set; }
        [Column("sim_card_carrier")]
        [StringLength(250)]
        public string SimCardCarrier { get; set; }
        [Column("connection_type")]
        [StringLength(250)]
        public string ConnectionType { get; set; }
        [Column("external_tid")]
        [StringLength(250)]
        public string ExternalTid { get; set; }
        [Column("device_type")]
        [StringLength(250)]
        public string DeviceType { get; set; }
        [Column("device_type_category")]
        [StringLength(250)]
        public string DeviceTypeCategory { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("ID_FALLA")]
        public int? IdFalla { get; set; }
        [Column("ID_PROYECTO")]
        public int? IdProyecto { get; set; }
        [Column("IS_FOLLOW_DISPATCH")]
        public int? IsFollowDispatch { get; set; }
    }
}
