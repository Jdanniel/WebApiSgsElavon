using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_MOVIMIENTOS_RETORNOS_INSUMOS")]
    public partial class BdBitacoraMovimientosRetornosInsumos
    {
        [Column("ID_BITACORA_MRI")]
        public int IdBitacoraMri { get; set; }
        [Column("ID_INSUMO")]
        public int IdInsumo { get; set; }
        [Column("ENTRADA")]
        public int Entrada { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_ENVIO")]
        public int? IdEnvio { get; set; }
        [Column("ID_TIPO_RESPONSABLE_ORIGEN")]
        public int? IdTipoResponsableOrigen { get; set; }
        [Column("ID_RESPONSABLE_ORIGEN")]
        public int? IdResponsableOrigen { get; set; }
        [Column("ID_TIPO_RESPONSABLE_DESTINO")]
        public int? IdTipoResponsableDestino { get; set; }
        [Column("ID_RESPONSABLE_DESTINO")]
        public int? IdResponsableDestino { get; set; }
        [Column("ID_STATUS_INSUMO")]
        public int? IdStatusInsumo { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_CONSOLIDADO")]
        [StringLength(100)]
        public string IdConsolidado { get; set; }
    }
}
