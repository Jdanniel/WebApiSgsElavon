using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_BBVA_MICROFORMAS_SERVICIOS")]
    public partial class CBbvaMicroformasServicios
    {
        [Column("ID_BBVA")]
        public int IdBbva { get; set; }
        [Column("DESSERV_BBVA")]
        [StringLength(255)]
        public string DesservBbva { get; set; }
        [Column("TIPO_SERVICIO")]
        [StringLength(255)]
        public string TipoServicio { get; set; }
        [Column("VIM")]
        [StringLength(255)]
        public string Vim { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("ID_SEGMENTO")]
        public int? IdSegmento { get; set; }
        [Column("ID_FALLA")]
        public int? IdFalla { get; set; }
    }
}
