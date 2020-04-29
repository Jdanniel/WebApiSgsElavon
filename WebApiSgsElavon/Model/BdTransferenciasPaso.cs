using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_TRANSFERENCIAS_PASO")]
    public partial class BdTransferenciasPaso
    {
        [Column("ID_TRANSFERENCIA_PASO")]
        public int IdTransferenciaPaso { get; set; }
        [Column("ID_TRANSFERENCIA")]
        public int? IdTransferencia { get; set; }
        [Column("NO_SERIE")]
        [StringLength(255)]
        public string NoSerie { get; set; }
        [Column("ID_TIPO_RESPONSABLE_ORIGEN")]
        public int? IdTipoResponsableOrigen { get; set; }
        [Column("ID_RESPONSABLE_ORIGEN")]
        public int? IdResponsableOrigen { get; set; }
        [Column("ID_TIPO_RESPONSABLE_DESTINO")]
        public int? IdTipoResponsableDestino { get; set; }
        [Column("ID_RESPONSABLE_DESTINO")]
        public int? IdResponsableDestino { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("IS_PROCESADA")]
        public int? IsProcesada { get; set; }
        [Column("ERROR")]
        [StringLength(255)]
        public string Error { get; set; }
    }
}
