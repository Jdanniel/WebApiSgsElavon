using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_MI_COMERCIO")]
    public partial class BdArMiComercio
    {
        [Column("ID_AR_MI_COMERCIO")]
        public int IdArMiComercio { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("NOTIFICADO")]
        public int? Notificado { get; set; }
        [Column("PROMOCIONES")]
        public int? Promociones { get; set; }
        [Column("DESCARGAR_APP")]
        public int? DescargarApp { get; set; }
        [Column("TELEFONO_1")]
        [StringLength(100)]
        public string Telefono1 { get; set; }
        [Column("TELEFONO_2")]
        [StringLength(100)]
        public string Telefono2 { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
