using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CARGAS")]
    public partial class BdCargas
    {
        public BdCargas()
        {
            BdNegociosIdCargaAltaNavigation = new HashSet<BdNegocios>();
            BdNegociosIdCargaStatusNavigation = new HashSet<BdNegocios>();
        }

        [Key]
        [Column("ID_CARGA")]
        public int IdCarga { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("FECHA", TypeName = "smalldatetime")]
        public DateTime Fecha { get; set; }
        [Column("ID_ATTACH_ARCHIVO1")]
        public int? IdAttachArchivo1 { get; set; }
        [Column("ID_STATUS_CARGA")]
        public int IdStatusCarga { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdCargaAltaNavigation")]
        public virtual ICollection<BdNegocios> BdNegociosIdCargaAltaNavigation { get; set; }
        [InverseProperty("IdCargaStatusNavigation")]
        public virtual ICollection<BdNegocios> BdNegociosIdCargaStatusNavigation { get; set; }
    }
}
