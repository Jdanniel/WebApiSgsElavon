using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_TRANSFERENCIAS")]
    public partial class BdBitacoraTransferencias
    {
        [Column("ID_BITACORA_TRANSFERENCIA")]
        public int IdBitacoraTransferencia { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("ID_TIPO_RESPONSABLE_ANTERIOR")]
        public int? IdTipoResponsableAnterior { get; set; }
        [Column("ID_RESPONSABLE_ANTERIOR")]
        public int? IdResponsableAnterior { get; set; }
        [Column("ID_TIPO_RESPONSABLE_ACTUAL")]
        public int? IdTipoResponsableActual { get; set; }
        [Column("ID_RESPONSABLE_ACTUAL")]
        public int? IdResponsableActual { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("COMENTARIOS")]
        public string Comentarios { get; set; }
    }
}
