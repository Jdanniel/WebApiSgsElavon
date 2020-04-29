using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_URGENCIA_SOLICITUD_ALMACEN")]
    public partial class CUrgenciaSolicitudAlmacen
    {
        public CUrgenciaSolicitudAlmacen()
        {
            BdSolicitudesAlmacen = new HashSet<BdSolicitudesAlmacen>();
            BdSolicitudesAlmacenOld = new HashSet<BdSolicitudesAlmacenOld>();
        }

        [Key]
        [Column("ID_URGENCIA_SOLICITUD_ALMACEN")]
        public int IdUrgenciaSolicitudAlmacen { get; set; }
        [Column("DESC_URGENCIA_SOLICITUD_ALMACEN")]
        [StringLength(50)]
        public string DescUrgenciaSolicitudAlmacen { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("IdUrgenciaSolicitudAlmacenNavigation")]
        public virtual ICollection<BdSolicitudesAlmacen> BdSolicitudesAlmacen { get; set; }
        [InverseProperty("IdUrgenciaSolicitudAlmacenNavigation")]
        public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOld { get; set; }
    }
}
