using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("ERRORES_AR_PREFACTURACION")]
    public partial class ErroresArPrefacturacion
    {
        [Column("ID_AR_ERROR")]
        public int IdArError { get; set; }
        [Column("ID_AR_PREFACTURACION")]
        public int? IdArPrefacturacion { get; set; }
        [Column("ERROR")]
        [StringLength(250)]
        public string Error { get; set; }
    }
}
