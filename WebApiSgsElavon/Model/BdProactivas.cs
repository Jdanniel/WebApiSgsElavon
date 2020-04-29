using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_PROACTIVAS")]
    public partial class BdProactivas
    {
        [Key]
        [Column("ID_PROACTIVA")]
        public int IdProactiva { get; set; }
        [Column("YEAR")]
        public int? Year { get; set; }
        [Column("MONTH")]
        public int? Month { get; set; }
        [Column("WEEK")]
        public int? Week { get; set; }
        [Column("NO_AFILIACION")]
        [StringLength(20)]
        public string NoAfiliacion { get; set; }
        [Column("LIBERA_YEAR")]
        public int? LiberaYear { get; set; }
        [Column("LIBERA_MES")]
        public int? LiberaMes { get; set; }
        [Column("LIBERA_DIA")]
        public int? LiberaDia { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ESTATUS")]
        [StringLength(15)]
        public string Estatus { get; set; }
    }
}
