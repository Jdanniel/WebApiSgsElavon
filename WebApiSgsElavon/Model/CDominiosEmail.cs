using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_DOMINIOS_EMAIL")]
    public partial class CDominiosEmail
    {
        [Key]
        [Column("ID_DOMINIO_EMAIL")]
        public int IdDominioEmail { get; set; }
        [Column("DESC_DOMINIO_EMAIL")]
        [StringLength(50)]
        public string DescDominioEmail { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}
