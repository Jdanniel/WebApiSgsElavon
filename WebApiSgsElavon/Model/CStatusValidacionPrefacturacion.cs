using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_VALIDACION_PREFACTURACION")]
    public partial class CStatusValidacionPrefacturacion
    {
        [Key]
        [Column("ID_STATUS_VALIDACION_PREFACTURACION")]
        public int IdStatusValidacionPrefacturacion { get; set; }
        [Column("DESC_STATUS_VALIDACION_PREFACTURACION")]
        [StringLength(250)]
        public string DescStatusValidacionPrefacturacion { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("IS_AUTOMATICA")]
        public int? IsAutomatica { get; set; }
        [Column("NEXT_ID_STATUS_AR")]
        public int? NextIdStatusAr { get; set; }
    }
}
