using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MC_VIA_GEOZONA_TECNICO")]
    public partial class BdMcViaGeozonaTecnico
    {
        [Key]
        [Column("ID_GEOZONA")]
        public int IdGeozona { get; set; }
        [Column("ID_TECNICO")]
        public int? IdTecnico { get; set; }
    }
}
