using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_FALLA_SEGMENTO")]
    public partial class CTipoFallaSegmento
    {
        [Key]
        [Column("ID_TIPO_FALLA_SEGMENTO")]
        public int IdTipoFallaSegmento { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_SEGMENTO")]
        public int? IdSegmento { get; set; }
        [Column("ID_TIPO_FALLA")]
        public int? IdTipoFalla { get; set; }
    }
}
