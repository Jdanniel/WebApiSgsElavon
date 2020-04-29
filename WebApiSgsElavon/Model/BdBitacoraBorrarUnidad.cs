using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_BORRAR_UNIDAD")]
    public partial class BdBitacoraBorrarUnidad
    {
        [Key]
        [Column("ID_BITACORA_BORRAR_UNIDAD")]
        public int IdBitacoraBorrarUnidad { get; set; }
        [Column("ID_UNIDAD")]
        public int IdUnidad { get; set; }
        [Column("FEC_BORRADO", TypeName = "smalldatetime")]
        public DateTime? FecBorrado { get; set; }
        [Column("ID_USUARIO_BORRADO")]
        public int IdUsuarioBorrado { get; set; }
    }
}
