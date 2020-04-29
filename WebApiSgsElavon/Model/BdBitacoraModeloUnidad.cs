using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_MODELO_UNIDAD")]
    public partial class BdBitacoraModeloUnidad
    {
        [Key]
        [Column("ID_BITACORA_MODELO_UNIDAD")]
        public int IdBitacoraModeloUnidad { get; set; }
        [Column("ID_UNIDAD")]
        public int IdUnidad { get; set; }
        [Column("ID_MODELO_VIEJO")]
        public int IdModeloViejo { get; set; }
        [Column("ID_MODELO_NUEVO")]
        public int IdModeloNuevo { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "smalldatetime")]
        public DateTime FechaAlta { get; set; }

        [ForeignKey("IdModeloNuevo")]
        [InverseProperty("BdBitacoraModeloUnidadIdModeloNuevoNavigation")]
        public virtual CModelos IdModeloNuevoNavigation { get; set; }
        [ForeignKey("IdModeloViejo")]
        [InverseProperty("BdBitacoraModeloUnidadIdModeloViejoNavigation")]
        public virtual CModelos IdModeloViejoNavigation { get; set; }
        [ForeignKey("IdUnidad")]
        [InverseProperty("BdBitacoraModeloUnidad")]
        public virtual BdUnidades IdUnidadNavigation { get; set; }
        [ForeignKey("IdUsuarioAlta")]
        [InverseProperty("BdBitacoraModeloUnidad")]
        public virtual CUsuarios IdUsuarioAltaNavigation { get; set; }
    }
}
