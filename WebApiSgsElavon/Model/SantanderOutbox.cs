using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("SANTANDER_OUTBOX")]
    public partial class SantanderOutbox
    {
        [Key]
        [Column("ID_SANTANDER_OUTBOX")]
        public int IdSantanderOutbox { get; set; }
        [Column("ID_AR")]
        public int IdAr { get; set; }
        [Column("ID_TIPO_OUTBOX_SANTANDER")]
        public int IdTipoOutboxSantander { get; set; }
        [Column("NAME_FILE")]
        [StringLength(50)]
        public string NameFile { get; set; }
        [Column("FECHA_ENVIO", TypeName = "datetime")]
        public DateTime? FechaEnvio { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
