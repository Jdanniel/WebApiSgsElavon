using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_USUARIO_STATUS_UNIDAD")]
    public partial class BdUsuarioStatusUnidad
    {
        [Column("ID_USUARIO_STATUS_UNIDAD")]
        public int IdUsuarioStatusUnidad { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ID_STATUS")]
        public int? IdStatus { get; set; }
        [Column("IS_CHECKED")]
        public int? IsChecked { get; set; }
    }
}
