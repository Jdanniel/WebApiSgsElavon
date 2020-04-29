using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MODELO_CELULAR")]
    public partial class BdModeloCelular
    {
        [Key]
        [Column("ID_MODELO_CELULAR")]
        public int IdModeloCelular { get; set; }
        [Column("DESC_MODELO_CELULAR")]
        [StringLength(250)]
        public string DescModeloCelular { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
