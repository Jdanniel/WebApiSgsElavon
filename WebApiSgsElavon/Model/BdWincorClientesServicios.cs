using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_WINCOR_CLIENTES_SERVICIOS")]
    public partial class BdWincorClientesServicios
    {
        [Column("ID_CLIENTE_SERVICIO_WINCOR")]
        public int IdClienteServicioWincor { get; set; }
        [Column("ID_CLIENTE_WINCOR")]
        public int IdClienteWincor { get; set; }
        [Column("ID_SERVICIO_WINCOR")]
        public int IdServicioWincor { get; set; }
        [Column("ID_FALLA")]
        public int? IdFalla { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
    }
}
