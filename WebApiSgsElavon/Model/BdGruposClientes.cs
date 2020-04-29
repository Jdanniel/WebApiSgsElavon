using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_GRUPOS_CLIENTES")]
    public partial class BdGruposClientes
    {
        [Key]
        [Column("ID_GRUPO_CLIENTE")]
        public int IdGrupoCliente { get; set; }
        [Column("ID_GRUPO")]
        public int? IdGrupo { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdCliente")]
        [InverseProperty("BdGruposClientes")]
        public virtual CClientes IdClienteNavigation { get; set; }
        [ForeignKey("IdGrupo")]
        [InverseProperty("BdGruposClientes")]
        public virtual CGrupos IdGrupoNavigation { get; set; }
    }
}
