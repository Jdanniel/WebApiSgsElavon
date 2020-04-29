using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_PRUEBAS_UNITARIAS")]
    public partial class BdPruebasUnitarias
    {
        [Column("ID_PRUEBAS")]
        public int IdPruebas { get; set; }
        [Column("DESC_ERROR")]
        [StringLength(250)]
        public string DescError { get; set; }
    }
}
