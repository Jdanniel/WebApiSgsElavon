using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_PLAZA_NEGOCIO")]
    public partial class CTipoPlazaNegocio
    {
        [Key]
        [Column("ID_TIPO_PLAZA_NEGOCIO")]
        public int IdTipoPlazaNegocio { get; set; }
        [Column("DESC_TIPO_PLAZA_NEGOCIO")]
        [StringLength(50)]
        public string DescTipoPlazaNegocio { get; set; }
    }
}
