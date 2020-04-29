using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_ZONAS_AGENTE_CALL_CENTER")]
    public partial class CZonasAgenteCallCenter
    {
        [Key]
        [Column("ID_ZONA_AGENTE_CALLCENTER")]
        public int IdZonaAgenteCallcenter { get; set; }
        [Column("ID_AGENTE")]
        public int IdAgente { get; set; }
        [Column("ID_ZONA")]
        public int IdZona { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}
