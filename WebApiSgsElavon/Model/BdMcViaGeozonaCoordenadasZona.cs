using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MC_VIA_GEOZONA_COORDENADAS_ZONA")]
    public partial class BdMcViaGeozonaCoordenadasZona
    {
        [Column("ID_GEOZONA_COORDENADAS_PLAZA")]
        public int IdGeozonaCoordenadasPlaza { get; set; }
        [Column("ID_ZONA")]
        public int? IdZona { get; set; }
        [Column("LATITUD")]
        [StringLength(25)]
        public string Latitud { get; set; }
        [Column("LONGITUD")]
        [StringLength(25)]
        public string Longitud { get; set; }
        [Column("ORDEN")]
        public int? Orden { get; set; }
    }
}
