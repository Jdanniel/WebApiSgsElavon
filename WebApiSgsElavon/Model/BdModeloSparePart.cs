using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MODELO_SPARE_PART")]
    public partial class BdModeloSparePart
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_MODELO")]
        public int IdModelo { get; set; }
        [Column("ID_PRODUCTO_SPARE_PART")]
        public int IdProductoSparePart { get; set; }
        [Column("ID_MARCA_SPARE_PART")]
        public int IdMarcaSparePart { get; set; }
        [Column("ID_SPARE_PART")]
        public int IdSparePart { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}
