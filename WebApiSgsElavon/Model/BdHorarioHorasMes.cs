using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_HORARIO_HORAS_MES")]
    public partial class BdHorarioHorasMes
    {
        [Key]
        [Column("ID_HORARIO_HORAS_MES")]
        public int IdHorarioHorasMes { get; set; }
        [Column("ID_HORARIO")]
        public int IdHorario { get; set; }
        [Column("MES")]
        public int Mes { get; set; }
        [Column("ANIO")]
        public int Anio { get; set; }
        [Column("HORAS_MES")]
        public int? HorasMes { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdHorario")]
        [InverseProperty("BdHorarioHorasMes")]
        public virtual CHorarios IdHorarioNavigation { get; set; }
    }
}
