using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ENVIO_ELAVON")]
    public partial class BdEnvioElavon
    {
        [Key]
        [Column("ID_ENVIO_ELAVON")]
        public int IdEnvioElavon { get; set; }
        [Column("XML_DATA", TypeName = "xml")]
        public string XmlData { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("IS_PROCESADO")]
        public int? IsProcesado { get; set; }
        [Column("NOMBRE_ARCHIVO")]
        [StringLength(250)]
        public string NombreArchivo { get; set; }
    }
}
