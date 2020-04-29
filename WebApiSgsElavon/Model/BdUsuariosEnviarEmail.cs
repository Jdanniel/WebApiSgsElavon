using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_USUARIOS_ENVIAR_EMAIL")]
    public partial class BdUsuariosEnviarEmail
    {
        [Column("ID_USUARIO_ENVIAR_EMAIL")]
        public int IdUsuarioEnviarEmail { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ID_SEND_USUARIO_ALTA")]
        public int? IdSendUsuarioAlta { get; set; }
    }
}
