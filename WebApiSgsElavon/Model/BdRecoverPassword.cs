using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_RECOVER_PASSWORD")]
    public partial class BdRecoverPassword
    {
        [Column("ID_RECOVERY_PASSWORD")]
        public int IdRecoveryPassword { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("TEMPORARY_PASSWORD")]
        public string TemporaryPassword { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
