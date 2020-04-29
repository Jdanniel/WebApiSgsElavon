using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_PASO_CAMBIO_STATUS_UNIDAD_MASIVO")]
    public partial class BdPasoCambioStatusUnidadMasivo
    {
        [Column("ID_PASO_CAMBIO_STATUS_UNIDAD_MASIVO")]
        public int IdPasoCambioStatusUnidadMasivo { get; set; }
        [Column("NO_SERIE")]
        public string NoSerie { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int? IdTipoResponsable { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("ID_STATUS_UNIDAD")]
        public int? IdStatusUnidad { get; set; }
        [Column("ID_CARGA")]
        public int? IdCarga { get; set; }
        [Column("FEC_CARGA", TypeName = "datetime")]
        public DateTime? FecCarga { get; set; }
        [Column("ID_USUARIO_CARGA")]
        public int? IdUsuarioCarga { get; set; }
        [Column("VALIDACION")]
        public string Validacion { get; set; }
        [Column("COMENTARIO")]
        public string Comentario { get; set; }
    }
}
