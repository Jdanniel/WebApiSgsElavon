using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_GARANTIA_ALMACEN")]
    public partial class BdGarantiaAlmacen
    {
        [Key]
        [Column("ID_GARANTIA_ALMACEN")]
        public int IdGarantiaAlmacen { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_WEEK_DAYS")]
        public int? IdWeekDays { get; set; }
        [Column("HORAS_GARANTIA")]
        public int? HorasGarantia { get; set; }
        [Column("HORAS")]
        public int? Horas { get; set; }
        [Column("MINUTOS")]
        public int? Minutos { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(15)]
        public string Status { get; set; }
    }
}
