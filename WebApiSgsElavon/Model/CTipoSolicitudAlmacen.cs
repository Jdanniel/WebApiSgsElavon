using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_SOLICITUD_ALMACEN")]
    public partial class CTipoSolicitudAlmacen
    {
        public CTipoSolicitudAlmacen()
        {
            BdSolicitudesAlmacen = new HashSet<BdSolicitudesAlmacen>();
            BdSolicitudesAlmacenOld = new HashSet<BdSolicitudesAlmacenOld>();
        }

        [Key]
        [Column("ID_TIPO_SOLICITUD_ALMACEN")]
        public int IdTipoSolicitudAlmacen { get; set; }
        [Column("DESC_TIPO_SOLICITUD_ALMACEN")]
        [StringLength(50)]
        public string DescTipoSolicitudAlmacen { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("IdTipoSolicitudAlmacenNavigation")]
        public virtual ICollection<BdSolicitudesAlmacen> BdSolicitudesAlmacen { get; set; }
        [InverseProperty("IdTipoSolicitudAlmacenNavigation")]
        public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOld { get; set; }
    }
}
