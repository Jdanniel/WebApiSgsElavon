using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CAUSA_CANCELACION_SOLICITUD_ALMACEN")]
    public partial class CCausaCancelacionSolicitudAlmacen
    {
        [Key]
        [Column("ID_CAUSA_CANCELACION_SOLICITUD_ALMACEN")]
        public int IdCausaCancelacionSolicitudAlmacen { get; set; }
        [Column("DESC_CAUSA_CANCELACION_SOLICITUD_ALMACEN")]
        [StringLength(250)]
        public string DescCausaCancelacionSolicitudAlmacen { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}
