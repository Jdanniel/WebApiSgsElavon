using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SERVICIO_CAUSA_RECHAZO_PRECIO")]
    public partial class BdServicioCausaRechazoPrecio
    {
        [Key]
        [Column("ID_SERVICIO_CAUSA_RECHAZO_PRECIO")]
        public int IdServicioCausaRechazoPrecio { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("ID_ESPECIFICACION_CAUSA_RECHAZO")]
        public int? IdEspecificacionCausaRechazo { get; set; }
        [Column("PRECIO", TypeName = "numeric(18, 2)")]
        public decimal? Precio { get; set; }
    }
}
