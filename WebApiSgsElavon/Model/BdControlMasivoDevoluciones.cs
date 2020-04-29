using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CONTROL_MASIVO_DEVOLUCIONES")]
    public partial class BdControlMasivoDevoluciones
    {
        [Column("ID_CONTROL_MASIVO_DEVOLUCION")]
        public int IdControlMasivoDevolucion { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("NO_SERIE")]
        [StringLength(250)]
        public string NoSerie { get; set; }
        [Column("ERROR")]
        [StringLength(250)]
        public string Error { get; set; }
        [Column("STATUS")]
        [StringLength(250)]
        public string Status { get; set; }
    }
}
