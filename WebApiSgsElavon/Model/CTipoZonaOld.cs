using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_ZONA_OLD")]
    public partial class CTipoZonaOld
    {
        [Column("ID_TIPO_ZONA")]
        public int IdTipoZona { get; set; }
        [Column("DESC_TIPO_ZONA")]
        [StringLength(50)]
        public string DescTipoZona { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}
