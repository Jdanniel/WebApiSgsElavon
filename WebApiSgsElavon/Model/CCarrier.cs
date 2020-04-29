using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CARRIER")]
    public partial class CCarrier
    {
        [Key]
        [Column("ID_CARRIER")]
        public int IdCarrier { get; set; }
        [Required]
        [Column("DESC_CARRIER")]
        [StringLength(50)]
        public string DescCarrier { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("LETRA_MIN")]
        public int? LetraMin { get; set; }
        [Column("LETRA_MAX")]
        public int? LetraMax { get; set; }
        [Column("NUM_MIN")]
        public int? NumMin { get; set; }
        [Column("NUM_MAX")]
        public int? NumMax { get; set; }
        [Column("CARACTER")]
        [StringLength(50)]
        public string Caracter { get; set; }
        [Column("CARACTER_OBLIGATORIO")]
        public int? CaracterObligatorio { get; set; }
        [Column("LONG_MIN")]
        public int? LongMin { get; set; }
        [Column("LONG_MAX")]
        public int? LongMax { get; set; }
        [Column("DIGITO_VERIFICADOR")]
        public int? DigitoVerificador { get; set; }
    }
}
