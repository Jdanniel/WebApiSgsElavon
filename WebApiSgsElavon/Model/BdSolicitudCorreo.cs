using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUD_CORREO")]
    public partial class BdSolicitudCorreo
    {
        [Column("ID_SOLICITUD_CORREO")]
        public int IdSolicitudCorreo { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_NEGOCIO")]
        public int? IdNegocio { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("NO_AR")]
        [StringLength(100)]
        public string NoAr { get; set; }
        [Column("NEMONICO")]
        [StringLength(150)]
        public string Nemonico { get; set; }
        [Column("NO_SERIE_EQUIPO")]
        [StringLength(200)]
        public string NoSerieEquipo { get; set; }
        [Column("IMEI")]
        [StringLength(50)]
        public string Imei { get; set; }
        [Column("ESTATUS")]
        public int? Estatus { get; set; }
        [Column("ID_CORREO")]
        [StringLength(100)]
        public string IdCorreo { get; set; }
        [Column("FECHA_CORREO", TypeName = "datetime")]
        public DateTime? FechaCorreo { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("OBSERVACIONES")]
        [StringLength(3000)]
        public string Observaciones { get; set; }
        [Column("ID_CARGA")]
        public int? IdCarga { get; set; }
    }
}
