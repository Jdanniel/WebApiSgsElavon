using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUD_ALMACEN_COMENTARIO")]
    public partial class BdSolicitudAlmacenComentario
    {
        [Column("ID_COMENTARIO_SOLICITUD_ALMACEN")]
        public int IdComentarioSolicitudAlmacen { get; set; }
        [Column("ID_SOLICITUD_ALMACEN")]
        public int? IdSolicitudAlmacen { get; set; }
        [Column("DESC_COMENTARIO_SOLICITUD_ALMACEN")]
        [StringLength(1000)]
        public string DescComentarioSolicitudAlmacen { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_STATUS_SOLICITUD_ALMACEN")]
        public int? IdStatusSolicitudAlmacen { get; set; }
    }
}
