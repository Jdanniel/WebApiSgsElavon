using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_ARCHIVO")]
    public partial class CTipoArchivo
    {
        [Key]
        [Column("ID_TIPO_ARCHIVO")]
        public int IdTipoArchivo { get; set; }
        [Column("DESC_TIPO_ARCHIVO")]
        [StringLength(50)]
        public string DescTipoArchivo { get; set; }
        [Required]
        [Column("EXTENSION")]
        [StringLength(4)]
        public string Extension { get; set; }
        [Column("IMAGEN")]
        [StringLength(20)]
        public string Imagen { get; set; }
    }
}
