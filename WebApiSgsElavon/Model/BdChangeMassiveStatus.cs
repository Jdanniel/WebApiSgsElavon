using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CHANGE_MASSIVE_STATUS")]
    public partial class BdChangeMassiveStatus
    {
        [Column("ID_CHANGE_MASSIVE_STATUS")]
        public int IdChangeMassiveStatus { get; set; }
        [Column("ID_CARGA")]
        public int? IdCarga { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("ID_STATUS")]
        public int? IdStatus { get; set; }
        [Column("NO_SERIE")]
        [StringLength(255)]
        public string NoSerie { get; set; }
        [Column("ERRORES")]
        [StringLength(255)]
        public string Errores { get; set; }
        [Column("IS_PROCESADO")]
        public int? IsProcesado { get; set; }
    }
}
