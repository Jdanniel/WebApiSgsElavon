using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_COMPROMISOS")]
    public partial class BdCompromisos
    {
        [Key]
        [Column("ID_COMPROMISO")]
        public int IdCompromiso { get; set; }
        [Column("NOMBRE_JUNTA")]
        public int? NombreJunta { get; set; }
        [Column("DESC_COMPROMISO")]
        [StringLength(255)]
        public string DescCompromiso { get; set; }
        [Column("ID_AREA")]
        public int? IdArea { get; set; }
        [Column("ID_USUARIO_RESPONSABLE")]
        public int? IdUsuarioResponsable { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("OBSERVACIONES")]
        [StringLength(255)]
        public string Observaciones { get; set; }
        [Column("FEC_INI", TypeName = "smalldatetime")]
        public DateTime? FecIni { get; set; }
        [Column("FEC_FIN", TypeName = "smalldatetime")]
        public DateTime? FecFin { get; set; }
        [Column("FEC_REAL_TERMINO", TypeName = "smalldatetime")]
        public DateTime? FecRealTermino { get; set; }
        [Column("CALIF")]
        public int? Calif { get; set; }
        [Column("STATUS")]
        public int? Status { get; set; }
        [Column("ID_USUARIO_RESPONSABLE_COMPROMISO")]
        public int? IdUsuarioResponsableCompromiso { get; set; }
        [Column("STATUS_COMPROMISO")]
        [StringLength(50)]
        public string StatusCompromiso { get; set; }
        [Column("CODIGO_CONTROL")]
        [StringLength(50)]
        public string CodigoControl { get; set; }
        [Column("ID_PRIORIDADES")]
        public int? IdPrioridades { get; set; }
    }
}
