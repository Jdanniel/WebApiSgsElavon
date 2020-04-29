using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BLOQUEOS")]
    public partial class BdBloqueos
    {
        [Key]
        [Column("ID_BLOQUEO")]
        public int IdBloqueo { get; set; }
        [Column("MONTH")]
        public int Month { get; set; }
        [Column("YEAR")]
        public int Year { get; set; }
        [Required]
        [Column("NO_AFILIACION")]
        [StringLength(50)]
        public string NoAfiliacion { get; set; }
        [Column("CP")]
        [StringLength(5)]
        public string Cp { get; set; }
        [Required]
        [Column("PROVEEDOR")]
        [StringLength(30)]
        public string Proveedor { get; set; }
        [Required]
        [Column("TERRITORIO")]
        [StringLength(30)]
        public string Territorio { get; set; }
        [Column("TOTAL_ROLLOS")]
        public int TotalRollos { get; set; }
        [Column("BLOQUEO")]
        public int Bloqueo { get; set; }
        [Column("MENSAJE")]
        [StringLength(200)]
        public string Mensaje { get; set; }
    }
}
