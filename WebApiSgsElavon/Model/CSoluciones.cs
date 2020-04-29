using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_SOLUCIONES")]
    public partial class CSoluciones
    {
        public CSoluciones()
        {
            BdServicioSolucion = new HashSet<BdServicioSolucion>();
        }

        [Key]
        [Column("ID_SOLUCION")]
        public int IdSolucion { get; set; }
        [Column("DESC_SOLUCION")]
        [StringLength(50)]
        public string DescSolucion { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("CLAVE")]
        [StringLength(20)]
        public string Clave { get; set; }
        [Column("IS_EXITO")]
        public int? IsExito { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [InverseProperty("IdSolucionNavigation")]
        public virtual ICollection<BdServicioSolucion> BdServicioSolucion { get; set; }
    }
}
