using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MODELO_CONECTIVIDAD")]
    public partial class BdModeloConectividad
    {
        [Column("ID_MODELO_CONECTIVIDAD")]
        public int IdModeloConectividad { get; set; }
        [Column("ID_MODELO")]
        public int IdModelo { get; set; }
        [Column("ID_CONECTIVIDAD")]
        public int IdConectividad { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
    }
}
