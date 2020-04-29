using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_TRANSFERENCIAS")]
    public partial class BdTransferencias
    {
        [Column("ID_TRANSFERENCIA")]
        public int IdTransferencia { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_STATUS_TRANSFERENCIA")]
        public int? IdStatusTransferencia { get; set; }
        [Column("STATUS")]
        [StringLength(255)]
        public string Status { get; set; }
        [Column("SYSTEM_FILENAME")]
        [StringLength(255)]
        public string SystemFilename { get; set; }
        [Column("USER_FILENAME")]
        [StringLength(255)]
        public string UserFilename { get; set; }
    }
}
