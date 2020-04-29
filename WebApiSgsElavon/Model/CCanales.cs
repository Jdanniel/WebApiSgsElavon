using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CANALES")]
    public partial class CCanales
    {
        [Column("ID_CANAL")]
        public int IdCanal { get; set; }
        [Column("DESC_CANAL")]
        [StringLength(255)]
        public string DescCanal { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
    }
}
