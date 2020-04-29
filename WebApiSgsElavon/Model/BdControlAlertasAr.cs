using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CONTROL_ALERTAS_AR")]
    public partial class BdControlAlertasAr
    {
        [Column("ID_CONTROL_AR")]
        public int IdControlAr { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("NO_AR")]
        [StringLength(250)]
        public string NoAr { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("AVISADO")]
        public int? Avisado { get; set; }
    }
}
