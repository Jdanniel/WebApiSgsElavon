using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CATEGORIA_VALIDA_DISPOSITIVOS")]
    public partial class CCategoriaValidaDispositivos
    {
        [Key]
        [Column("ID_CATEGORIA_VALIDA_DISPOSITIVOS")]
        public int IdCategoriaValidaDispositivos { get; set; }
        [Column("IDENTIFICADOR")]
        [StringLength(50)]
        public string Identificador { get; set; }
        [Column("DESC_IDENTIFICADOR")]
        [StringLength(150)]
        public string DescIdentificador { get; set; }
    }
}
