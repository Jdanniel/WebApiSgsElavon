using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_SERVICIO_MENSAJERIA")]
    public partial class CServicioMensajeria
    {
        public CServicioMensajeria()
        {
            BdEnvios = new HashSet<BdEnvios>();
        }

        [Key]
        [Column("ID_SERVICIO_MENSAJERIA")]
        public int IdServicioMensajeria { get; set; }
        [Column("DESC_SERVICIO_MENSAJERIA")]
        [StringLength(50)]
        public string DescServicioMensajeria { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("IS_INTERNO")]
        public int? IsInterno { get; set; }
        [Column("PAGINA_WEB")]
        [StringLength(50)]
        public string PaginaWeb { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("IS_CAMION")]
        public int? IsCamion { get; set; }

        [InverseProperty("IdServicioMensajeriaNavigation")]
        public virtual ICollection<BdEnvios> BdEnvios { get; set; }
    }
}
