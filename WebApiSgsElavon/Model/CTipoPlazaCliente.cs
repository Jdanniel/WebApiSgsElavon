using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_PLAZA_CLIENTE")]
    public partial class CTipoPlazaCliente
    {
        [Key]
        [Column("ID_TIPO_PLAZA_CLIENTE")]
        public int IdTipoPlazaCliente { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("DESC_TIPO_PLAZA_CLIENTE")]
        [StringLength(50)]
        public string DescTipoPlazaCliente { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Column("IS_DEFAULT")]
        public int? IsDefault { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("DIAS")]
        public int? Dias { get; set; }
    }
}
