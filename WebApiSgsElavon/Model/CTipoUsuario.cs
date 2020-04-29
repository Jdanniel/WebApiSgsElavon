using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_USUARIO")]
    public partial class CTipoUsuario
    {
        public CTipoUsuario()
        {
            CUsuarios = new HashSet<CUsuarios>();
        }

        [Key]
        [Column("ID_TIPO_USUARIO")]
        public int IdTipoUsuario { get; set; }
        [Column("DESC_TIPO_USUARIO")]
        [StringLength(50)]
        public string DescTipoUsuario { get; set; }
        [Column("IS_TECNICO")]
        public int? IsTecnico { get; set; }
        [Column("IS_SOPORTE")]
        public int? IsSoporte { get; set; }
        [Column("IS_VIEW_ALL_SERVICIOS")]
        public int IsViewAllServicios { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("IS_TARGET_CHANGE_SENT")]
        public int? IsTargetChangeSent { get; set; }
        [Column("IS_CHANGE_UNIT_STOCK")]
        public int? IsChangeUnitStock { get; set; }
        [Column("IS_SYS_ADMIN")]
        public int? IsSysAdmin { get; set; }
        [Column("IS_EDIT_FISCAL")]
        public int? IsEditFiscal { get; set; }
        [Column("IS_TECHNICIANS_ASSIGNED_ONLY")]
        public int? IsTechniciansAssignedOnly { get; set; }
        [Column("IS_AUTO_ASSIGN_TECHNICIANS")]
        public int? IsAutoAssignTechnicians { get; set; }

        [InverseProperty("IdTipoUsuarioNavigation")]
        public virtual ICollection<CUsuarios> CUsuarios { get; set; }
    }
}
