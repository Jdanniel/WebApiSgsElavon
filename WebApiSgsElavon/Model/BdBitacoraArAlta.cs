using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_AR_ALTA")]
    public partial class BdBitacoraArAlta
    {
        [Column("ID_AR_BITACORA_AR_ALTA")]
        public int IdArBitacoraArAlta { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
