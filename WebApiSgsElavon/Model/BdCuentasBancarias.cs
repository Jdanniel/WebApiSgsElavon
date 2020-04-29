using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CUENTAS_BANCARIAS")]
    public partial class BdCuentasBancarias
    {
        [Key]
        [Column("ID_CUENTA_BANCARIA")]
        public int IdCuentaBancaria { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Required]
        [Column("NOMBRE_BANCO")]
        [StringLength(50)]
        public string NombreBanco { get; set; }
        [Required]
        [Column("NUMERO_CUENTA")]
        [StringLength(50)]
        public string NumeroCuenta { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_BANCO")]
        public int IdBanco { get; set; }
    }
}
