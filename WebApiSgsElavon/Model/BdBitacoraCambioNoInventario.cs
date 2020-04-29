using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_CAMBIO_NO_INVENTARIO")]
    public partial class BdBitacoraCambioNoInventario
    {
        [Column("ID_BITACORA_CAMBIO_NO_INVENTARIO")]
        public int IdBitacoraCambioNoInventario { get; set; }
        [Column("ID_CARGA")]
        public int? IdCarga { get; set; }
        [Column("SERIE")]
        [StringLength(255)]
        public string Serie { get; set; }
        [Column("NO_INVENTARIO")]
        [StringLength(255)]
        public string NoInventario { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
    }
}
