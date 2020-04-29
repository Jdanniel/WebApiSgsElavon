using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_ALMACEN_RESPONSABLE")]
    public partial class BdBitacoraAlmacenResponsable
    {
        [Column("ID_BITACORA_ALMACEN_RESPONSABLE")]
        public int IdBitacoraAlmacenResponsable { get; set; }
        [Column("ID_ALMACEN")]
        public int? IdAlmacen { get; set; }
        [Column("ID_RESPONSABLE_ANTERIOR")]
        public int? IdResponsableAnterior { get; set; }
        [Column("ID_RESPONSABLE_ACTUAL")]
        public int? IdResponsableActual { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
