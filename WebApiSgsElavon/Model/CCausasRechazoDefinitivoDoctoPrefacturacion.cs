using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CAUSAS_RECHAZO_DEFINITIVO_DOCTO_PREFACTURACION")]
    public partial class CCausasRechazoDefinitivoDoctoPrefacturacion
    {
        [Key]
        [Column("ID_CAUSA_RECHAZO_DEFINITIVO_DOCTO_PREFACTURACION")]
        public int IdCausaRechazoDefinitivoDoctoPrefacturacion { get; set; }
        [Column("DESC_CAUSA_RECHAZO_DEFINITIVO_DOCTO_PREFACTURACION")]
        [StringLength(50)]
        public string DescCausaRechazoDefinitivoDoctoPrefacturacion { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
