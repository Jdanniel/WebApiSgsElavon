using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SERVICIO_SEGMENTO")]
    public partial class BdServicioSegmento
    {
        [Key]
        [Column("ID_SERVICIO_SEGMENTO")]
        public int IdServicioSegmento { get; set; }
        [Column("ID_SERVICIO")]
        public int IdServicio { get; set; }
        [Column("ID_SEGMENTO")]
        public int IdSegmento { get; set; }
        [Column("ID_TIPO_PLAZA")]
        public int? IdTipoPlaza { get; set; }
        [Column("HORAS_GARANTIA")]
        public int? HorasGarantia { get; set; }
        [Column("PRECIO_EXITO", TypeName = "numeric(18, 2)")]
        public decimal? PrecioExito { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        public int? CourtScheduleHours { get; set; }
        public int? CourtScheduleMinutes { get; set; }
        [Column("TR")]
        public int? Tr { get; set; }
        [Column("TS")]
        public int? Ts { get; set; }
        [Column("TA")]
        public int? Ta { get; set; }
    }
}
