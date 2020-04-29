using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIMESTAMP")]
    public partial class CTimestamp
    {
        [Key]
        [Column("ID_TIMESTAMP")]
        public int IdTimestamp { get; set; }
        [Column("DESC_TIMESTAMP")]
        [StringLength(10)]
        public string DescTimestamp { get; set; }
        [Column("TIMESTAMP")]
        [StringLength(10)]
        public string Timestamp { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
