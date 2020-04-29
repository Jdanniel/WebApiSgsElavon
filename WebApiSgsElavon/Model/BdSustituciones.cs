using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SUSTITUCIONES")]
    public partial class BdSustituciones
    {
        [Key]
        [Column("ID_SUSTITUCION")]
        public int IdSustitucion { get; set; }
        [Column("ID_AR")]
        public int IdAr { get; set; }
        [Column("ID_NEGOCIO")]
        public int IdNegocio { get; set; }
        [Column("ID_TECNICO")]
        public int? IdTecnico { get; set; }
        [Column("ID_PARENT")]
        public int? IdParent { get; set; }
        [Column("ID_UNIDAD_ENTRADA")]
        public int IdUnidadEntrada { get; set; }
        [Column("NO_EQUIPO_ENTRADA")]
        [StringLength(50)]
        public string NoEquipoEntrada { get; set; }
        [Column("ID_UNIDAD_SALIDA")]
        public int IdUnidadSalida { get; set; }
        [Column("NO_EQUIPO_SALIDA")]
        [StringLength(50)]
        public string NoEquipoSalida { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdNegocio")]
        [InverseProperty("BdSustituciones")]
        public virtual BdNegocios IdNegocioNavigation { get; set; }
        [ForeignKey("IdTecnico")]
        [InverseProperty("BdSustituciones")]
        public virtual CUsuarios IdTecnicoNavigation { get; set; }
        [ForeignKey("IdUnidadEntrada")]
        [InverseProperty("BdSustitucionesIdUnidadEntradaNavigation")]
        public virtual BdUnidades IdUnidadEntradaNavigation { get; set; }
        [ForeignKey("IdUnidadSalida")]
        [InverseProperty("BdSustitucionesIdUnidadSalidaNavigation")]
        public virtual BdUnidades IdUnidadSalidaNavigation { get; set; }
    }
}
