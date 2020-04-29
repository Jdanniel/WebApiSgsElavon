using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_FOTO_AR")]
    public partial class BdFotoAr
    {
        [Key]
        [Column("ID_FOTO_AR")]
        public int IdFotoAr { get; set; }
        [Column("ID_ATTACH")]
        public int? IdAttach { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }

        [ForeignKey("IdAttach")]
        [InverseProperty("BdFotoAr")]
        public virtual BdAttach IdAttachNavigation { get; set; }
    }
}
