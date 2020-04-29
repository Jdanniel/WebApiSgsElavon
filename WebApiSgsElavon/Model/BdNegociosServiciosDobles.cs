using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_NEGOCIOS_SERVICIOS_DOBLES")]
    public partial class BdNegociosServiciosDobles
    {
        [Column("ID_NEGOCIO_SERVICIO_DOBLE")]
        public int IdNegocioServicioDoble { get; set; }
        [Column("ID_SERVICIO_DOBLE")]
        public int? IdServicioDoble { get; set; }
        [Column("NO_AFILIACION")]
        [StringLength(255)]
        public string NoAfiliacion { get; set; }
        [Column("DESCRIPCION_SERVICIO_DOBLE")]
        [StringLength(255)]
        public string DescripcionServicioDoble { get; set; }
        [Column("MENSAJE")]
        public string Mensaje { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("IS_EXITO")]
        public int? IsExito { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
