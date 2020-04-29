using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUD_CORREO_OKI")]
    public partial class BdSolicitudCorreoOki
    {
        [Column("ID_SOLICITUD_CORREO_OKI")]
        public int IdSolicitudCorreoOki { get; set; }
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
        [Column("TICKET")]
        [StringLength(50)]
        public string Ticket { get; set; }
        [Column("NOMBRE_CAJERO")]
        [StringLength(200)]
        public string NombreCajero { get; set; }
        [Column("FALLA")]
        [StringLength(500)]
        public string Falla { get; set; }
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
