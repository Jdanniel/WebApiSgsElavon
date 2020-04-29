using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_DESCRIPCION_TRABAJO")]
    public partial class CDescripcionTrabajo
    {
        [Key]
        [Column("ID_DESCRIPCION_TRABAJO")]
        public int IdDescripcionTrabajo { get; set; }
        [Column("ID_ESPECIF_TIPO_FALLA")]
        public int? IdEspecifTipoFalla { get; set; }
        [Column("DESC_TRABAJO")]
        [StringLength(1000)]
        public string DescTrabajo { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
