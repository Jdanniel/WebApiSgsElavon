using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_RETIROS")]
    public partial class BdRetiros
    {
        [Key]
        [Column("ID_RETIRO")]
        public int IdRetiro { get; set; }
        [Column("ID_AR")]
        public int IdAr { get; set; }
        [Column("ID_NEGOCIO")]
        public int IdNegocio { get; set; }
        [Column("ID_TECNICO")]
        public int? IdTecnico { get; set; }
        [Column("ID_UNIDAD")]
        public int IdUnidad { get; set; }
        [Column("IS_NUEVA")]
        public int? IsNueva { get; set; }
        [Column("IS_DANIADA")]
        public int? IsDaniada { get; set; }
        [Column("ID_PARENT")]
        public int? IdParent { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("TIPO")]
        [StringLength(10)]
        public string Tipo { get; set; }
        [Column("ID_CONECTIVIDAD")]
        public int? IdConectividad { get; set; }
        [Column("ID_APLICATIVO")]
        public int? IdAplicativo { get; set; }

        [ForeignKey("IdNegocio")]
        [InverseProperty("BdRetiros")]
        public virtual BdNegocios IdNegocioNavigation { get; set; }
        [ForeignKey("IdParent")]
        [InverseProperty("BdRetirosIdParentNavigation")]
        public virtual BdUnidades IdParentNavigation { get; set; }
        [ForeignKey("IdTecnico")]
        [InverseProperty("BdRetiros")]
        public virtual CUsuarios IdTecnicoNavigation { get; set; }
        [ForeignKey("IdUnidad")]
        [InverseProperty("BdRetirosIdUnidadNavigation")]
        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}
