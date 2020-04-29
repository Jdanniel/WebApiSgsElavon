using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MC_VIA_GEOZONA_COORDENADAS")]
    public partial class BdMcViaGeozonaCoordenadas
    {
        [Key]
        [Column("ID_GEOZONA_COORDENADAS")]
        public int IdGeozonaCoordenadas { get; set; }
        [Column("ID_TECNICO")]
        public int? IdTecnico { get; set; }
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
