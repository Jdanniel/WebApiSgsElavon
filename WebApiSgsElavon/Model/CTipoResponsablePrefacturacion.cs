using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_RESPONSABLE_PREFACTURACION")]
    public partial class CTipoResponsablePrefacturacion
    {
        [Column("ID_TIPO_RESPONSABLE_PREFACTURACION")]
        public int IdTipoResponsablePrefacturacion { get; set; }
        [Column("DESC_TIPO_RESPONSABLE_PREFACTURACION")]
        [StringLength(50)]
        public string DescTipoResponsablePrefacturacion { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}
