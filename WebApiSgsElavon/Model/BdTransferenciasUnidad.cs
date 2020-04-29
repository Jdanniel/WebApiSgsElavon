using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_TRANSFERENCIAS_UNIDAD")]
    public partial class BdTransferenciasUnidad
    {
        [Column("ID_TRANSFERENCIA_UNIDAD")]
        public int IdTransferenciaUnidad { get; set; }
        [Column("ID_TRANSFERENCIA")]
        public int? IdTransferencia { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
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
        [Column("IS_RECIBIDO")]
        public int? IsRecibido { get; set; }
        [Column("FEC_RECIBIDO", TypeName = "datetime")]
        public DateTime? FecRecibido { get; set; }
    }
}
