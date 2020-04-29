using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_USUARIO")]
    public partial class CStatusUsuario
    {
        [Key]
        [Column("ID_STATUS_USUARIO")]
        public int IdStatusUsuario { get; set; }
        [Column("DESC_STATUS_USUARIO")]
        [StringLength(50)]
        public string DescStatusUsuario { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("REQUIERE_PERIODO")]
        public int? RequierePeriodo { get; set; }
        [Column("ENVIOS")]
        public int? Envios { get; set; }
        [Column("VIATICOS")]
        public int? Viaticos { get; set; }
    }
}
