using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_WINCOR_EQUIVALENCIAS_SGS")]
    public partial class CWincorEquivalenciasSgs
    {
        [Column("ID_EQUIVALENCIA")]
        public int IdEquivalencia { get; set; }
        [Column("ID_STATUS_WINCOR")]
        public int IdStatusWincor { get; set; }
        [Column("DESC_STATUS_WINCOR")]
        [StringLength(300)]
        public string DescStatusWincor { get; set; }
        [Column("ID_STATUS_AR")]
        public int IdStatusAr { get; set; }

        [ForeignKey("IdStatusAr")]
        [InverseProperty("CWincorEquivalenciasSgs")]
        public virtual CStatusAr IdStatusArNavigation { get; set; }
    }
}
