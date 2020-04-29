using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_STORE_ALTA_MANUAL")]
    public partial class BdStoreAltaManual
    {
        [Column("ID_STORE_ALTA_MANUAL")]
        public int IdStoreAltaManual { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("TEXTO")]
        [StringLength(255)]
        public string Texto { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
