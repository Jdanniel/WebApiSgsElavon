using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AUDITORIA_CIERRES")]
    public partial class BdAuditoriaCierres
    {
        [Column("ID_AUDITORIA_CIERRES")]
        public int IdAuditoriaCierres { get; set; }
        [Column("ID_TABLA")]
        public int? IdTabla { get; set; }
        [Column("PROCESO")]
        public string Proceso { get; set; }
        [Column("TABLA_AFECTADA")]
        public string TablaAfectada { get; set; }
        [Column("ACCION")]
        public string Accion { get; set; }
        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }
        [Column("ID_ARCHIVO")]
        public int? IdArchivo { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("PASO")]
        public int? Paso { get; set; }
    }
}
