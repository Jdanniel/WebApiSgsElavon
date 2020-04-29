using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_HISTORICO_PASSWORD")]
    public partial class BdHistoricoPassword
    {
        [Key]
        [Column("ID_HISTORICO_PASSWORD")]
        public int IdHistoricoPassword { get; set; }
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }
        [Required]
        [Column("PASSWORD")]
        [StringLength(200)]
        public string Password { get; set; }
        [Column("FEC_ALTA", TypeName = "date")]
        public DateTime FecAlta { get; set; }
    }
}
