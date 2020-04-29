using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_ALMACEN_STATUS")]
    public partial class BdBitacoraAlmacenStatus
    {
        [Column("ID_BITACORA")]
        public int IdBitacora { get; set; }
        [Column("ID_ALMACEN")]
        public int? IdAlmacen { get; set; }
        [Column("STATUS_ANTERIOR")]
        [StringLength(50)]
        public string StatusAnterior { get; set; }
        [Column("STATUS_ACTUAL")]
        [StringLength(50)]
        public string StatusActual { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
