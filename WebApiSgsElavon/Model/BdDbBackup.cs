using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_DB_BACKUP")]
    public partial class BdDbBackup
    {
        [Key]
        [Column("ID_DB_BACKUP")]
        public int IdDbBackup { get; set; }
        [Required]
        [Column("FILE_PATH")]
        [StringLength(255)]
        public string FilePath { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Column("FEC_STATUS", TypeName = "smalldatetime")]
        public DateTime? FecStatus { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}
