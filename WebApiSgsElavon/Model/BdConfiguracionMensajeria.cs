using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CONFIGURACION_MENSAJERIA")]
    public partial class BdConfiguracionMensajeria
    {
        [Column("ID_CONFIGURACION")]
        public int IdConfiguracion { get; set; }
        [Column("ID_SERVICIO_MENSAJERIA")]
        public int? IdServicioMensajeria { get; set; }
        [Column("LONGITUD")]
        public int? Longitud { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(255)]
        public string Status { get; set; }
        [Column("FIULL", TypeName = "decimal(8, 4)")]
        public decimal? Fiull { get; set; }
    }
}
