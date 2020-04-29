using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_SPARE_PART")]
    public partial class BdArSparePart
    {
        [Key]
        [Column("ID_AR_SPARE_PART")]
        public int IdArSparePart { get; set; }
        [Column("ID_AR")]
        public int IdAr { get; set; }
        [Column("ID_SPARE_PART")]
        public int IdSparePart { get; set; }
        [Column("CANTIDAD")]
        public int Cantidad { get; set; }
        [Column("PRECIO_UNITARIO", TypeName = "numeric(18, 2)")]
        public decimal PrecioUnitario { get; set; }
        [Column("PRECIO_TOTAL", TypeName = "numeric(18, 2)")]
        public decimal PrecioTotal { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }

        [ForeignKey("IdSparePart")]
        [InverseProperty("BdArSparePart")]
        public virtual CSpareParts IdSparePartNavigation { get; set; }
    }
}
