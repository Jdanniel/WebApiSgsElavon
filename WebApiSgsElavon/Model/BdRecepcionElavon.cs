using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_RECEPCION_ELAVON")]
    public partial class BdRecepcionElavon
    {
        [Key]
        [Column("ID_RECEPCION_ELAVON")]
        public int IdRecepcionElavon { get; set; }
        [Column("XML_DATA", TypeName = "xml")]
        public string XmlData { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("IS_PROCESADO")]
        public int? IsProcesado { get; set; }
        [Column("NOMBRE_ARCHIVO")]
        [StringLength(2000)]
        public string NombreArchivo { get; set; }
    }
}
