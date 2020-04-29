using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CAMBIOS_ESTATUS_PERMITITDOS_UNIDADES")]
    public partial class BdCambiosEstatusPermititdosUnidades
    {
        [Column("ID_CAMBIO_ESTATUS_PERMITIDO")]
        public int IdCambioEstatusPermitido { get; set; }
        [Column("ID_STATUS_INI")]
        public int? IdStatusIni { get; set; }
        [Column("ID_STATUS_FIN")]
        public int? IdStatusFin { get; set; }
        [Column("IS_VALIDACION_ENVIO")]
        public int? IsValidacionEnvio { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int? IdTipoResponsable { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("ARCHIVO_OBLIGATORIO")]
        public int? ArchivoObligatorio { get; set; }
        [Column("STATUS")]
        public int? Status { get; set; }
        [Column("LIBERAR_ENVIO")]
        public int? LiberarEnvio { get; set; }
    }
}
