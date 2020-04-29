using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_STATUS_TIPO_USUARIO")]
    public partial class BdBitacoraStatusTipoUsuario
    {
        [Key]
        [Column("ID_BITACORA_STATUS_TIPO_USUARIO")]
        public int IdBitacoraStatusTipoUsuario { get; set; }
        [Column("ID_USUARIO_CAMBIO")]
        public int? IdUsuarioCambio { get; set; }
        [Column("FEC_CAMBIO", TypeName = "smalldatetime")]
        public DateTime? FecCambio { get; set; }
        [Column("CAMBIO")]
        [StringLength(250)]
        public string Cambio { get; set; }
        [Column("ID_TIPO_USUARIO")]
        public int? IdTipoUsuario { get; set; }
    }
}
