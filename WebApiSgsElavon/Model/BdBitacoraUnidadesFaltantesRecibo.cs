using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_UNIDADES_FALTANTES_RECIBO")]
    public partial class BdBitacoraUnidadesFaltantesRecibo
    {
        [Column("ID_BITACORA_UNIDAD_FALTANTE")]
        public int IdBitacoraUnidadFaltante { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("ID_ENVIO")]
        public int? IdEnvio { get; set; }
        [Column("ID_STATUS_ENVIO")]
        public int? IdStatusEnvio { get; set; }
        [Column("FEC_ENVIO")]
        [StringLength(1)]
        public string FecEnvio { get; set; }
        [Column("ID_TIPO_RESPONSABLE_ORIGEN")]
        public int? IdTipoResponsableOrigen { get; set; }
        [Column("ID_RESPONSABLE_ORIGEN")]
        public int? IdResponsableOrigen { get; set; }
        [Column("ID_TIPO_RESPONSABLE_DESTINO")]
        public int? IdTipoResponsableDestino { get; set; }
        [Column("ID_RESPONSABLE_DESTINO")]
        public int? IdResponsableDestino { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("NO_UNIDADES_NO_RECIBIDAS")]
        public int? NoUnidadesNoRecibidas { get; set; }
        [Column("NO_UNIDADES_INSUMOS_NO_RECIBIDAS")]
        public int? NoUnidadesInsumosNoRecibidas { get; set; }
    }
}
