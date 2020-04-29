using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_INSTALACIONES")]
    public partial class BdInstalaciones
    {
        [Key]
        [Column("ID_INSTALACION")]
        public int IdInstalacion { get; set; }
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
        [Column("ID_PARENT")]
        public int? IdParent { get; set; }
        [Column("ID_CLIENTE_INI")]
        public int? IdClienteIni { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("TIPO")]
        [StringLength(10)]
        public string Tipo { get; set; }

        [ForeignKey("IdClienteIni")]
        [InverseProperty("BdInstalaciones")]
        public virtual CClientes IdClienteIniNavigation { get; set; }
        [ForeignKey("IdNegocio")]
        [InverseProperty("BdInstalaciones")]
        public virtual BdNegocios IdNegocioNavigation { get; set; }
        [ForeignKey("IdParent")]
        [InverseProperty("BdInstalacionesIdParentNavigation")]
        public virtual BdUnidades IdParentNavigation { get; set; }
        [ForeignKey("IdTecnico")]
        [InverseProperty("BdInstalaciones")]
        public virtual CUsuarios IdTecnicoNavigation { get; set; }
        [ForeignKey("IdUnidad")]
        [InverseProperty("BdInstalacionesIdUnidadNavigation")]
        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}
