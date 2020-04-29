using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_RELACION_FACTURA_ENVIO")]
    public partial class BdRelacionFacturaEnvio
    {
        [Column("ID_RELACION_FACTURA_ENVIO")]
        public int IdRelacionFacturaEnvio { get; set; }
        [Column("ID_ENVIO")]
        public int? IdEnvio { get; set; }
        [Column("IS_PROCESADA")]
        public int? IsProcesada { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("NO_FACTURA")]
        [StringLength(255)]
        public string NoFactura { get; set; }
    }
}
