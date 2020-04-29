using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AUDITORIA_PROCESOS_INTERNOS")]
    public partial class BdAuditoriaProcesosInternos
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("PROCESO")]
        [StringLength(100)]
        public string Proceso { get; set; }
        [Column("ERROR_NUMBER")]
        public int? ErrorNumber { get; set; }
        [Column("ERROR_MESSAGE")]
        public string ErrorMessage { get; set; }
        [Column("REFERENCIA")]
        [StringLength(100)]
        public string Referencia { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
