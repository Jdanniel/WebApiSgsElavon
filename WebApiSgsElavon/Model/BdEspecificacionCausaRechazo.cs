using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ESPECIFICACION_CAUSA_RECHAZO")]
    public partial class BdEspecificacionCausaRechazo
    {
        [Key]
        [Column("ID_ESPECIFICACION_CAUSA_RECHAZO")]
        public int IdEspecificacionCausaRechazo { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_CAUSA_RECHAZO_PARENT")]
        public int? IdCausaRechazoParent { get; set; }
        [Column("DESC_ESPECIFICACION_CAUSA_RECHAZO")]
        [StringLength(250)]
        public string DescEspecificacionCausaRechazo { get; set; }
        [Column("STATUS")]
        [StringLength(25)]
        public string Status { get; set; }
        [Column("NO_VALIDACION_NEEDED")]
        public int? NoValidacionNeeded { get; set; }
        [Column("IS_TIR_NEEDED")]
        public int? IsTirNeeded { get; set; }
    }
}
