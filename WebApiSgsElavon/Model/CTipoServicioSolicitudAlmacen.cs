using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_SERVICIO_SOLICITUD_ALMACEN")]
    public partial class CTipoServicioSolicitudAlmacen
    {
        public CTipoServicioSolicitudAlmacen()
        {
            BdSolicitudesAlmacen = new HashSet<BdSolicitudesAlmacen>();
        }

        [Key]
        [Column("ID_TIPO_SERVICIO_SOLICITUD_ALMACEN")]
        public int IdTipoServicioSolicitudAlmacen { get; set; }
        [Column("DESC_TIPO_SERVICIO_SOLICITUD_ALMACEN")]
        [StringLength(50)]
        public string DescTipoServicioSolicitudAlmacen { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("IdTipoServicioNavigation")]
        public virtual ICollection<BdSolicitudesAlmacen> BdSolicitudesAlmacen { get; set; }
    }
}
