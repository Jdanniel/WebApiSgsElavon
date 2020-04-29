using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CARGA_UNIDAD_NO_INVENTARIO")]
    public partial class BdCargaUnidadNoInventario
    {
        [Column("ID_CARGA_UNIDAD_NO_INVENTARIO")]
        public int IdCargaUnidadNoInventario { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("NO_INVENTARION")]
        [StringLength(255)]
        public string NoInventarion { get; set; }
    }
}
