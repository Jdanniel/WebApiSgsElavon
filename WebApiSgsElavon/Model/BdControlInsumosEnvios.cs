using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CONTROL_INSUMOS_ENVIOS")]
    public partial class BdControlInsumosEnvios
    {
        [Column("ID_CONTROL_INSUMO_ENVIO")]
        public int IdControlInsumoEnvio { get; set; }
        [Column("ID_ENVIO")]
        public int? IdEnvio { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("ID_RESPONSABLE_ORIGEN")]
        public int? IdResponsableOrigen { get; set; }
        [Column("ID_RESPONSABLE_DESTINO")]
        public int? IdResponsableDestino { get; set; }
        [Column("ID_TIPO_RESPONSABLE_ORIGEN")]
        public int? IdTipoResponsableOrigen { get; set; }
        [Column("ID_TIPO_RESPONSABLE_DESTINO")]
        public int? IdTipoResponsableDestino { get; set; }
        [Column("CANTIDAD")]
        public int? Cantidad { get; set; }
        [Column("ID_STATUS_INSUMO")]
        public int? IdStatusInsumo { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("IS_RECEPTION")]
        public int? IsReception { get; set; }
        [Column("CANTIDAD_RETORNO")]
        public int? CantidadRetorno { get; set; }
    }
}
