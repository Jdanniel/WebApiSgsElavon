using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MODELO_SUSTITUTO")]
    public partial class BdModeloSustituto
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("ID_MODELO_SUSTITUTO")]
        public int? IdModeloSustituto { get; set; }
        [Column("ID_SOFTWARE")]
        public int? IdSoftware { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }

        [ForeignKey("IdModelo")]
        [InverseProperty("BdModeloSustitutoIdModeloNavigation")]
        public virtual CModelos IdModeloNavigation { get; set; }
        [ForeignKey("IdModeloSustituto")]
        [InverseProperty("BdModeloSustitutoIdModeloSustitutoNavigation")]
        public virtual CModelos IdModeloSustitutoNavigation { get; set; }
        [ForeignKey("IdSoftware")]
        [InverseProperty("BdModeloSustituto")]
        public virtual CSoftware IdSoftwareNavigation { get; set; }
    }
}
