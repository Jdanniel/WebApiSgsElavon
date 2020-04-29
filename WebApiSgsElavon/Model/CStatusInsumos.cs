using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_INSUMOS")]
    public partial class CStatusInsumos
    {
        public CStatusInsumos()
        {
            BdBitacoraInsumosIdStatusInsumoFinNavigation = new HashSet<BdBitacoraInsumos>();
            BdBitacoraInsumosIdStatusInsumoIniNavigation = new HashSet<BdBitacoraInsumos>();
        }

        [Key]
        [Column("ID_STATUS_INSUMO")]
        public int IdStatusInsumo { get; set; }
        [Column("DESC_STATUS_INSUMO")]
        [StringLength(50)]
        public string DescStatusInsumo { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdStatusInsumoFinNavigation")]
        public virtual ICollection<BdBitacoraInsumos> BdBitacoraInsumosIdStatusInsumoFinNavigation { get; set; }
        [InverseProperty("IdStatusInsumoIniNavigation")]
        public virtual ICollection<BdBitacoraInsumos> BdBitacoraInsumosIdStatusInsumoIniNavigation { get; set; }
    }
}
