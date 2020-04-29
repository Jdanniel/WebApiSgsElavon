using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_STATUS_DOCTO_TIPO_RESPONSABLE_PREFACTURACION")]
    public partial class BdStatusDoctoTipoResponsablePrefacturacion
    {
        [Column("ID_STATUS_DOCTO_TIPO_RESPONSABLE_PREFACTURACION")]
        public int IdStatusDoctoTipoResponsablePrefacturacion { get; set; }
        [Column("ID_TIPO_DOCTO_PREFACTURACION")]
        public int? IdTipoDoctoPrefacturacion { get; set; }
        [Column("ID_STATUS_DOCTO_PREFACTURACION")]
        public int? IdStatusDoctoPrefacturacion { get; set; }
        [Column("ID_TIPO_RESPONSABLE_PREFACTURACION")]
        public int? IdTipoResponsablePrefacturacion { get; set; }
        [Column("IS_PREFACTURACION_ASSIGN")]
        public int? IsPrefacturacionAssign { get; set; }
        [Column("IS_PARTNER_ASSIGN")]
        public int? IsPartnerAssign { get; set; }
        [Column("IS_CLIENTE_ASSIGN")]
        public int? IsClienteAssign { get; set; }
    }
}
