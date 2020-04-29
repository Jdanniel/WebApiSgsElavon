using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_ODT_ONBASE_CONFIRMACION")]
    public partial class BdBitacoraOdtOnbaseConfirmacion
    {
        [Column("ID_BITACORA_ODT_ONBASE_CONFIRMACION")]
        public int IdBitacoraOdtOnbaseConfirmacion { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("FEC_MODIFICACION", TypeName = "datetime")]
        public DateTime? FecModificacion { get; set; }
    }
}
