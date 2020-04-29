using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SERVICIO_SOLUCION_PRECIO")]
    public partial class BdServicioSolucionPrecio
    {
        [Key]
        [Column("ID_SERVICIO_SOLUCION_PRECIO")]
        public int IdServicioSolucionPrecio { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("ID_ESPECIF_TIPO_FALLA")]
        public int? IdEspecifTipoFalla { get; set; }
        [Column("PRECIO", TypeName = "numeric(18, 2)")]
        public decimal? Precio { get; set; }
    }
}
