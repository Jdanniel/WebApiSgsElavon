using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MODELO_MODULO")]
    public partial class BdModeloModulo
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_MODELO")]
        public int IdModelo { get; set; }
        [Column("ID_PRODUCTO_MODULO")]
        public int IdProductoModulo { get; set; }
        [Column("ID_MARCA_MODULO")]
        public int IdMarcaModulo { get; set; }
        [Column("ID_MODELO_MODULO")]
        public int IdModeloModulo { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdMarcaModulo")]
        [InverseProperty("BdModeloModulo")]
        public virtual CMarcas IdMarcaModuloNavigation { get; set; }
        [ForeignKey("IdModeloModulo")]
        [InverseProperty("BdModeloModuloIdModeloModuloNavigation")]
        public virtual CModelos IdModeloModuloNavigation { get; set; }
        [ForeignKey("IdModelo")]
        [InverseProperty("BdModeloModuloIdModeloNavigation")]
        public virtual CModelos IdModeloNavigation { get; set; }
        [ForeignKey("IdProductoModulo")]
        [InverseProperty("BdModeloModulo")]
        public virtual CProductos IdProductoModuloNavigation { get; set; }
    }
}
