using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_OPCIONES_REINGENIERIA_TIPO_USUARIO")]
    public partial class BdOpcionesReingenieriaTipoUsuario
    {
        [Column("ID_OPCIONES_REINGENIERIA_TIPO_USUARIO")]
        public int IdOpcionesReingenieriaTipoUsuario { get; set; }
        [Column("ID_TIPO_USUARIO")]
        public int? IdTipoUsuario { get; set; }
        [Column("ID_OPCIONES_REINGENIERIA")]
        public int? IdOpcionesReingenieria { get; set; }
    }
}
