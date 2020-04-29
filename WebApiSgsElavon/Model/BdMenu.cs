using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MENU")]
    public partial class BdMenu
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_MENU0")]
        public int IdMenu0 { get; set; }
        [Column("ID_MENU1")]
        public int? IdMenu1 { get; set; }
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
    }
}
