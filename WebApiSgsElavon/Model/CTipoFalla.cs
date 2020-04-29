using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_FALLA")]
    public partial class CTipoFalla
    {
        [Key]
        [Column("ID_TIPO_FALLA")]
        public int IdTipoFalla { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("DESC_TIPO_FALLA")]
        [StringLength(50)]
        public string DescTipoFalla { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("IS_COBRABLE")]
        public int? IsCobrable { get; set; }
        [Column("IS_ESPECIAL")]
        public int? IsEspecial { get; set; }
    }
}
