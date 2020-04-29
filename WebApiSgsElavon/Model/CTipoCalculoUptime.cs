using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_CALCULO_UPTIME")]
    public partial class CTipoCalculoUptime
    {
        public CTipoCalculoUptime()
        {
            CClientes = new HashSet<CClientes>();
        }

        [Column("ID_TIPO_CALCULO_UPTIME")]
        public int IdTipoCalculoUptime { get; set; }
        [Column("DESC_TIPO_CALCULO_UPTIME")]
        [StringLength(50)]
        public string DescTipoCalculoUptime { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdTipoCalculoUptimeNavigation")]
        public virtual ICollection<CClientes> CClientes { get; set; }
    }
}
