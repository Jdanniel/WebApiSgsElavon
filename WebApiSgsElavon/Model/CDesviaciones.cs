using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_DESVIACIONES")]
    public partial class CDesviaciones
    {
        public CDesviaciones()
        {
            BdArDesviacion = new HashSet<BdArDesviacion>();
        }

        [Key]
        [Column("ID_DESVIACION")]
        public int IdDesviacion { get; set; }
        [Column("DESC_DESVIACION")]
        [StringLength(250)]
        public string DescDesviacion { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("IS_DESVIACION_TEMP")]
        public int? IsDesviacionTemp { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("IS_ADMINISTRADOR_LOGISTICO")]
        public int? IsAdministradorLogistico { get; set; }
        [Column("IS_LABORATORIO")]
        public int? IsLaboratorio { get; set; }

        [InverseProperty("IdDesviacionNavigation")]
        public virtual ICollection<BdArDesviacion> BdArDesviacion { get; set; }
    }
}
