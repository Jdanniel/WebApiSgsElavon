using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_STATUS_TIPO_USUARIO")]
    public partial class BdStatusTipoUsuario
    {
        [Key]
        [Column("ID_STATUS_TIPO_USUARIO")]
        public int IdStatusTipoUsuario { get; set; }
        [Column("ID_TIPO_USUARIO")]
        public int? IdTipoUsuario { get; set; }
        [Column("ID_STATUS_AR")]
        public int? IdStatusAr { get; set; }
    }
}
