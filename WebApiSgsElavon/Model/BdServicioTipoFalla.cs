using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SERVICIO_TIPO_FALLA")]
    public partial class BdServicioTipoFalla
    {
        [Key]
        [Column("ID_SERVICIO_TIPO_FALLA")]
        public int IdServicioTipoFalla { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("ID_TIPO_FALLA")]
        public int? IdTipoFalla { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
    }
}
