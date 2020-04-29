using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SERVICIOS_FALLAS_PROY_ESPECIALES")]
    public partial class BdServiciosFallasProyEspeciales
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_PROYECTO_ESPECIAL")]
        public int? IdProyectoEspecial { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("ID_FALLA")]
        public int? IdFalla { get; set; }
        [Column("MENSAJE", TypeName = "text")]
        public string Mensaje { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO")]
        [StringLength(10)]
        public string IdUsuario { get; set; }
    }
}
