using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CHANGE_STATUS_AR_PASO")]
    public partial class BdChangeStatusArPaso
    {
        [Column("ID_CHANGE_STATUS_AR")]
        public int IdChangeStatusAr { get; set; }
        [Column("ID_CARGA")]
        public int? IdCarga { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_STATUS_AR")]
        public int? IdStatusAr { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ERROR")]
        [StringLength(255)]
        public string Error { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
