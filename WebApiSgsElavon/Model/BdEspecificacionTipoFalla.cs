using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ESPECIFICACION_TIPO_FALLA")]
    public partial class BdEspecificacionTipoFalla
    {
        [Key]
        [Column("ID_ESPECIF_TIPO_FALLA")]
        public int IdEspecifTipoFalla { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_FALLA_PARENT")]
        public int? IdFallaParent { get; set; }
        [Column("DESC_ESPECIFICACION_FALLA")]
        [StringLength(250)]
        public string DescEspecificacionFalla { get; set; }
        [Column("STATUS")]
        [StringLength(25)]
        public string Status { get; set; }
        [Column("IS_COBRABLE")]
        public int? IsCobrable { get; set; }
        [Column("NO_VALIDACION_NEEDED")]
        public int? NoValidacionNeeded { get; set; }
        [Column("IS_TIR_NEEDED")]
        public int? IsTirNeeded { get; set; }
    }
}
