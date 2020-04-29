using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIEMPOS")]
    public partial class CTiempos
    {
        [Key]
        [Column("ID_TIEMPOS")]
        public int IdTiempos { get; set; }
        [Column("HORAS")]
        public int? Horas { get; set; }
        [Column("MINUTOS")]
        public int? Minutos { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("TRASLADO")]
        public int? Traslado { get; set; }
        [Column("SERVICIO")]
        public int? Servicio { get; set; }
        [Column("MIN_TOTALES")]
        public int? MinTotales { get; set; }
    }
}
