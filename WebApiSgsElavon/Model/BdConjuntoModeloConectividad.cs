using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CONJUNTO_MODELO_CONECTIVIDAD")]
    public partial class BdConjuntoModeloConectividad
    {
        [Column("ID_CONJUNTO")]
        public int IdConjunto { get; set; }
        [Column("ID_MODELO_PARENT")]
        public int? IdModeloParent { get; set; }
        [Column("ID_CONECTIVIDAD_PARENT")]
        public int? IdConectividadParent { get; set; }
        [Column("ID_CONECTIVIDAD")]
        public int? IdConectividad { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
    }
}
