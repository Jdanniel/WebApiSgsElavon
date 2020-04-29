using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_DIAS_ATENCION")]
    public partial class BdArDiasAtencion
    {
        [Column("ID_AR_DIAS_ATENCION")]
        public int IdArDiasAtencion { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("LUNES")]
        public int? Lunes { get; set; }
        [Column("MARTES")]
        public int? Martes { get; set; }
        [Column("MIERCOLES")]
        public int? Miercoles { get; set; }
        [Column("JUEVES")]
        public int? Jueves { get; set; }
        [Column("VIERNES")]
        public int? Viernes { get; set; }
        [Column("SABADO")]
        public int? Sabado { get; set; }
        [Column("DOMINGO")]
        public int? Domingo { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
