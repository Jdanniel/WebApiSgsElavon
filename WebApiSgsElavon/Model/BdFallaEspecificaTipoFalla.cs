using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_FALLA_ESPECIFICA_TIPO_FALLA")]
    public partial class BdFallaEspecificaTipoFalla
    {
        [Key]
        [Column("ID_FALLA_ESPECIFICA_TIPO_FALLA")]
        public int IdFallaEspecificaTipoFalla { get; set; }
        [Column("ID_FALLA")]
        public int? IdFalla { get; set; }
        [Column("ID_TIPO_FALLA")]
        public int? IdTipoFalla { get; set; }
        [Column("ID_ESPECIF_TIPO_FALLA")]
        public int? IdEspecifTipoFalla { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("STATUS")]
        [StringLength(25)]
        public string Status { get; set; }
    }
}
