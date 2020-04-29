using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_WINCOR_SERVICIOS")]
    public partial class BdWincorServicios
    {
        [Column("ID_SERVICIO_WINCOR")]
        public int IdServicioWincor { get; set; }
        [Column("NOMBRE")]
        [StringLength(50)]
        public string Nombre { get; set; }
    }
}
