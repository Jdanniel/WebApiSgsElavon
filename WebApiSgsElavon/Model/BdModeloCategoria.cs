using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MODELO_CATEGORIA")]
    public partial class BdModeloCategoria
    {
        [Column("ID_MODELO_CATEGORIA")]
        public int IdModeloCategoria { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("ID_CATEGORIA")]
        public int? IdCategoria { get; set; }
    }
}
