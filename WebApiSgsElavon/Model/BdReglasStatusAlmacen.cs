using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_REGLAS_STATUS_ALMACEN")]
    public partial class BdReglasStatusAlmacen
    {
        [Key]
        [Column("ID_REGLAS_STATUS_ALMACEN")]
        public int IdReglasStatusAlmacen { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_STATUS_SOLICITUD_ALMACEN")]
        public int? IdStatusSolicitudAlmacen { get; set; }
        [Column("MINUTOS")]
        public int? Minutos { get; set; }
        [Column("ID_OPERADOR")]
        public int? IdOperador { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("COLOR_RGB")]
        [StringLength(50)]
        public string ColorRgb { get; set; }
    }
}
