using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_ESTADOS_DAR_BBVA_94")]
    public partial class CEstadosDarBbva94
    {
        [Column("ID_ESTADO")]
        public int IdEstado { get; set; }
        [Column("ESTADO")]
        [StringLength(255)]
        public string Estado { get; set; }
        [Column("DAR")]
        [StringLength(255)]
        public string Dar { get; set; }
        [Column("PROVEEDOR")]
        [StringLength(255)]
        public string Proveedor { get; set; }
    }
}
