using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CARGAS_CONFIRMACIONES")]
    public partial class BdCargasConfirmaciones
    {
        public BdCargasConfirmaciones()
        {
            BdArchivosConfirmaciones = new HashSet<BdArchivosConfirmaciones>();
            BdConfirmaciones = new HashSet<BdConfirmaciones>();
            BdConfirmacionesIntermedia = new HashSet<BdConfirmacionesIntermedia>();
        }

        [Column("ID_CARGA_CONFIRMACIONES")]
        public int IdCargaConfirmaciones { get; set; }
        [Required]
        [Column("NOMBRE_CARGA_CONFIRMACIONES")]
        [StringLength(50)]
        public string NombreCargaConfirmaciones { get; set; }
        [Column("ID_STATUS_CARGA_CONFIRMACIONES")]
        public int IdStatusCargaConfirmaciones { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdCargaConfirmacionesNavigation")]
        public virtual ICollection<BdArchivosConfirmaciones> BdArchivosConfirmaciones { get; set; }
        [InverseProperty("IdCargaConfirmacionesNavigation")]
        public virtual ICollection<BdConfirmaciones> BdConfirmaciones { get; set; }
        [InverseProperty("IdCargaConfirmacionesNavigation")]
        public virtual ICollection<BdConfirmacionesIntermedia> BdConfirmacionesIntermedia { get; set; }
    }
}
