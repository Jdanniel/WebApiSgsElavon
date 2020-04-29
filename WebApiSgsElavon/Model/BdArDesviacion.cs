using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_DESVIACION")]
    public partial class BdArDesviacion
    {
        [Key]
        [Column("ID_AR_DESVIACION")]
        public int IdArDesviacion { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_DESVIACION")]
        public int? IdDesviacion { get; set; }
        [Column("ID_TECNICO")]
        public int? IdTecnico { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("FECHA_INICIO", TypeName = "smalldatetime")]
        public DateTime? FechaInicio { get; set; }
        [Column("FECHA_FIN", TypeName = "smalldatetime")]
        public DateTime? FechaFin { get; set; }
        [Column("COMENTARIO")]
        [StringLength(250)]
        public string Comentario { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(500)]
        public string Descripcion { get; set; }
        [Column("HAVE_DESCRIPCION")]
        public int? HaveDescripcion { get; set; }

        [ForeignKey("IdDesviacion")]
        [InverseProperty("BdArDesviacion")]
        public virtual CDesviaciones IdDesviacionNavigation { get; set; }
    }
}
