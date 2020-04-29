using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_AR_EQ")]
    public partial class CStatusArEq
    {
        [Key]
        [Column("ID_STATUS_AR_EQ")]
        public int IdStatusArEq { get; set; }
        [Column("DESC_STATUS_AR_EQ")]
        [StringLength(50)]
        public string DescStatusArEq { get; set; }
        [Column("ID_STATUS_AR")]
        public int? IdStatusAr { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }

        [ForeignKey("IdStatusAr")]
        [InverseProperty("CStatusArEq")]
        public virtual CStatusAr IdStatusArNavigation { get; set; }
    }
}
