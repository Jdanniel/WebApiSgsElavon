using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_REGLAS_MODELOS")]
    public partial class BdReglasModelos
    {
        [Column("ID_REGLAS")]
        public int IdReglas { get; set; }
        [Column("ID_MODELO")]
        public int IdModelo { get; set; }
        [Column("LETRAS_MIN")]
        public int LetrasMin { get; set; }
        [Column("LETRAS_MAX")]
        public int LetrasMax { get; set; }
        [Column("NUMERO_MIN")]
        public int NumeroMin { get; set; }
        [Column("NUMERO_MAX")]
        public int NumeroMax { get; set; }
        [Column("LONG_MIN")]
        public int LongMin { get; set; }
        [Column("LONG_MAX")]
        public int LongMax { get; set; }
        [Column("STATUS")]
        [StringLength(250)]
        public string Status { get; set; }
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
