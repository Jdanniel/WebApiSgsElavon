using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOPORTE_TECNICO")]
    public partial class BdSoporteTecnico
    {
        [Key]
        [Column("ID_SOPORTE_TECNICO")]
        public int IdSoporteTecnico { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_TIPO_SOPORTE_TECNICO")]
        public int? IdTipoSoporteTecnico { get; set; }
        [Column("ID_STATUS_AR_ANT")]
        public int? IdStatusArAnt { get; set; }
        [Column("ID_USUARIO_SOPORTE")]
        public int? IdUsuarioSoporte { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_CONFIRM")]
        public int? IdUsuarioConfirm { get; set; }
        [Column("FEC_CONFIRM", TypeName = "smalldatetime")]
        public DateTime? FecConfirm { get; set; }
        [Column("IS_CHECKED")]
        public int? IsChecked { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [ForeignKey("IdTipoSoporteTecnico")]
        [InverseProperty("BdSoporteTecnico")]
        public virtual CTipoSoporteTecnico IdTipoSoporteTecnicoNavigation { get; set; }
    }
}
