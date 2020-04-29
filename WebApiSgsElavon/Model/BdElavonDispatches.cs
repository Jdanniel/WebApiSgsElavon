using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ELAVON_DISPATCHES")]
    public partial class BdElavonDispatches
    {
        [Key]
        [Column("ID_ELAVON_DISPATCHES")]
        public int IdElavonDispatches { get; set; }
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
        [Column("consumable_type")]
        [StringLength(250)]
        public string ConsumableType { get; set; }
        [Column("consumable_amt")]
        [StringLength(250)]
        public string ConsumableAmt { get; set; }
        [Column("accessory_type")]
        [StringLength(250)]
        public string AccessoryType { get; set; }
        [Column("accessory_amt")]
        [StringLength(250)]
        public string AccessoryAmt { get; set; }
        [Column("software_name")]
        [StringLength(250)]
        public string SoftwareName { get; set; }
        [Column("software_version")]
        [StringLength(250)]
        public string SoftwareVersion { get; set; }
        [Column("software_vendor")]
        [StringLength(250)]
        public string SoftwareVendor { get; set; }
    }
}
