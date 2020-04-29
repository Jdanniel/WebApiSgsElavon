using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_ETIQUETA_INFORMACION_RECHAZO")]
    public partial class CEtiquetaInformacionRechazo
    {
        [Column("ID_ETIQUETA_INFORMACION_RECHAZO")]
        public int IdEtiquetaInformacionRechazo { get; set; }
        [Column("DESC_ETIQUETA_INFORMACION_RECHAZO")]
        [StringLength(255)]
        public string DescEtiquetaInformacionRechazo { get; set; }
        [Column("TIPO")]
        [StringLength(255)]
        public string Tipo { get; set; }
        [Column("RUTA")]
        [StringLength(255)]
        public string Ruta { get; set; }
        [Column("CAMPO_SERVICIO")]
        [StringLength(255)]
        public string CampoServicio { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(255)]
        public string Status { get; set; }
    }
}
