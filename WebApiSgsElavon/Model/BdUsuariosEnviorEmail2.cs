using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_USUARIOS_ENVIOR_EMAIL_2")]
    public partial class BdUsuariosEnviorEmail2
    {
        [Column("ID_USUARIOS_ENVIOR_EMAIL_2")]
        public int IdUsuariosEnviorEmail2 { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ID_NOTIFICACIONES_EMAIL")]
        public int? IdNotificacionesEmail { get; set; }
        [Column("CHECKED")]
        public string Checked { get; set; }
        [Column("STATUS")]
        public string Status { get; set; }
    }
}
