using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_JOBS")]
    public partial class BdBitacoraJobs
    {
        [Key]
        [Column("ID_BITACORA_JOB")]
        public int IdBitacoraJob { get; set; }
        [Column("JOB_NAME")]
        [StringLength(50)]
        public string JobName { get; set; }
        [Column("FECHA", TypeName = "smalldatetime")]
        public DateTime? Fecha { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
