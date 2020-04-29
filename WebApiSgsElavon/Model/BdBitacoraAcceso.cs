using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_ACCESO")]
    public partial class BdBitacoraAcceso
    {
        [Column("ID_BITACORA")]
        public int IdBitacora { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ACCESO", TypeName = "smalldatetime")]
        public DateTime? Acceso { get; set; }
        [Column("FEC_STATUS", TypeName = "smalldatetime")]
        public DateTime? FecStatus { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("IP_CLIENTE")]
        [StringLength(30)]
        public string IpCliente { get; set; }
        [Column("HOST")]
        [StringLength(50)]
        public string Host { get; set; }
    }
}
