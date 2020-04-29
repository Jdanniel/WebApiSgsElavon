using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_PLAZA_CP")]
    public partial class BdPlazaCp
    {
        [Key]
        [Column("ID_PLAZA_CP")]
        public int IdPlazaCp { get; set; }
        [Column("ID_PLAZA")]
        public int? IdPlaza { get; set; }
        [Column("CP")]
        [StringLength(10)]
        public string Cp { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }

        [ForeignKey("IdPlaza")]
        [InverseProperty("BdPlazaCp")]
        public virtual CPlazas IdPlazaNavigation { get; set; }
    }
}
