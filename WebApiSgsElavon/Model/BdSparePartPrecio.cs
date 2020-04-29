using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SPARE_PART_PRECIO")]
    public partial class BdSparePartPrecio
    {
        [Key]
        [Column("ID_SPARE_PART_PRECIO")]
        public int IdSparePartPrecio { get; set; }
        [Column("ID_SPARE_PART")]
        public int IdSparePart { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_MONEDA")]
        public int? IdMoneda { get; set; }
        [Column("PRECIO", TypeName = "numeric(18, 2)")]
        public decimal? Precio { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }

        [ForeignKey("IdCliente")]
        [InverseProperty("BdSparePartPrecio")]
        public virtual CClientes IdClienteNavigation { get; set; }
        [ForeignKey("IdMoneda")]
        [InverseProperty("BdSparePartPrecio")]
        public virtual CMonedas IdMonedaNavigation { get; set; }
        [ForeignKey("IdSparePart")]
        [InverseProperty("BdSparePartPrecio")]
        public virtual CSpareParts IdSparePartNavigation { get; set; }
    }
}
