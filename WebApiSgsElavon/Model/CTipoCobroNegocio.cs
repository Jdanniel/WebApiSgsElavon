using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_COBRO_NEGOCIO")]
    public partial class CTipoCobroNegocio
    {
        [Key]
        [Column("ID_TIPO_COBRO_NEGOCIO")]
        public int IdTipoCobroNegocio { get; set; }
        [Column("DESC_TIPO_COBRO_NEGOCIO")]
        [StringLength(250)]
        public string DescTipoCobroNegocio { get; set; }
        [Column("STATUS")]
        [StringLength(20)]
        public string Status { get; set; }
    }
}
