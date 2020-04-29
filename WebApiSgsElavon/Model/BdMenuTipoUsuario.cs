using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MENU_TIPO_USUARIO")]
    public partial class BdMenuTipoUsuario
    {
        [Key]
        [Column("ID_MENU_TIPO_USUARIO")]
        public int IdMenuTipoUsuario { get; set; }
        [Column("ID_TIPO_USUARIO")]
        public int? IdTipoUsuario { get; set; }
        [Column("ID_PESTANAS_BITACORA_AR")]
        public int? IdPestanasBitacoraAr { get; set; }
    }
}
