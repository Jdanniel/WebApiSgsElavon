using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CAUSAS_RECHAZO_SEGMENTO")]
    public partial class CCausasRechazoSegmento
    {
        [Key]
        [Column("ID_CAUSA_RECHAZO_SEGMENTO")]
        public int IdCausaRechazoSegmento { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_SEGMENTO")]
        public int? IdSegmento { get; set; }
        [Column("ID_CAUSA_RECHAZO")]
        public int? IdCausaRechazo { get; set; }
    }
}
