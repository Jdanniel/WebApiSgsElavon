using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_VIATICO")]
    public partial class BdArViatico
    {
        [Key]
        [Column("ID_AR_VIATICO")]
        public int IdArViatico { get; set; }
        [Column("ID_AR")]
        public int IdAr { get; set; }
        [Column("ID_VIATICO")]
        public int IdViatico { get; set; }
        [Column("COSTO", TypeName = "numeric(18, 2)")]
        public decimal Costo { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdViatico")]
        [InverseProperty("BdArViatico")]
        public virtual CViaticos IdViaticoNavigation { get; set; }
    }
}
