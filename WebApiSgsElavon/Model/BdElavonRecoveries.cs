using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ELAVON_RECOVERIES")]
    public partial class BdElavonRecoveries
    {
        [Key]
        [Column("ID_ELAVON_RECOVERIES")]
        public int IdElavonRecoveries { get; set; }
        [Column("ID_ELAVON_INBOX")]
        public int? IdElavonInbox { get; set; }
        [Column("request_id")]
        [StringLength(250)]
        public string RequestId { get; set; }
        [Column("device_type")]
        [StringLength(250)]
        public string DeviceType { get; set; }
        [Column("device_type_category")]
        [StringLength(250)]
        public string DeviceTypeCategory { get; set; }
        [Column("serial")]
        [StringLength(250)]
        public string Serial { get; set; }
        [Column("accessory_type")]
        [StringLength(250)]
        public string AccessoryType { get; set; }
        [Column("reason")]
        [StringLength(250)]
        public string Reason { get; set; }
    }
}
