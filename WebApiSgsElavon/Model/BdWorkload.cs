using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_WORKLOAD")]
    public partial class BdWorkload
    {
        [Key]
        [Column("ID_WORKLOAD")]
        public int IdWorkload { get; set; }
        [Column("SPID_UNO")]
        public string SpidUno { get; set; }
        public string Status { get; set; }
        public string Login { get; set; }
        public string HostName { get; set; }
        public string BlkBy { get; set; }
        [Column("DBName")]
        public string Dbname { get; set; }
        public string Command { get; set; }
        [Column("CPUTime")]
        public string Cputime { get; set; }
        [Column("DiskIO")]
        public string DiskIo { get; set; }
        public string LastBatch { get; set; }
        public string ProgramName { get; set; }
        [Column("SPID")]
        public string Spid { get; set; }
        [Column("REQUESTID")]
        public string Requestid { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}
