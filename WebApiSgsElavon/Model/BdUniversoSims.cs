using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_UNIVERSO_SIMS")]
    public partial class BdUniversoSims
    {
        [Key]
        [Column("ID_UNIVERSO_SIMS")]
        public int IdUniversoSims { get; set; }
        [Column("SIM")]
        [StringLength(35)]
        public string Sim { get; set; }
        [Column("LINEA")]
        [StringLength(100)]
        public string Linea { get; set; }
        [Column("ORIGEN")]
        [StringLength(100)]
        public string Origen { get; set; }
        [Column("ESTATUS_GENERAL")]
        [StringLength(100)]
        public string EstatusGeneral { get; set; }
        [Column("FECHA_ACTUAL")]
        [StringLength(100)]
        public string FechaActual { get; set; }
        [Column("CARRIER")]
        [StringLength(100)]
        public string Carrier { get; set; }
        [Column("OBSERVACIONES", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FECHA_CARGA", TypeName = "datetime")]
        public DateTime? FechaCarga { get; set; }
        [Column("ID_PROCESO")]
        [StringLength(50)]
        public string IdProceso { get; set; }
        [Column("STATUS_CARGA")]
        [StringLength(20)]
        public string StatusCarga { get; set; }
    }
}
