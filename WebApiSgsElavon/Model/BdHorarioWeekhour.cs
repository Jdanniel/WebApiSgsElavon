using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_HORARIO_WEEKHOUR")]
    public partial class BdHorarioWeekhour
    {
        [Column("ID_HORARIO_WEEKHOUR")]
        public int IdHorarioWeekhour { get; set; }
        [Column("ID_HORARIO")]
        public int? IdHorario { get; set; }
        [Column("ID_WEEKHOUR")]
        public int? IdWeekhour { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdHorario")]
        [InverseProperty("BdHorarioWeekhour")]
        public virtual CHorarios IdHorarioNavigation { get; set; }
        [ForeignKey("IdWeekhour")]
        [InverseProperty("BdHorarioWeekhour")]
        public virtual CWeekhours IdWeekhourNavigation { get; set; }
    }
}
