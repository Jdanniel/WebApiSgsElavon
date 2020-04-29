using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_ETIQUETA_INFORMACION_UNIDAD")]
    public partial class CEtiquetaInformacionUnidad
    {
        [Key]
        [Column("ID_ETIQUETA_INFORMACION_UNIDAD")]
        public int IdEtiquetaInformacionUnidad { get; set; }
        [Column("DESC_ETIQUETA_INFORMACION_UNIDAD")]
        [StringLength(250)]
        public string DescEtiquetaInformacionUnidad { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
