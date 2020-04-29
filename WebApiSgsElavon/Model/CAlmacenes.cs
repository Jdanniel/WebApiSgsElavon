using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_ALMACENES")]
    public partial class CAlmacenes
    {
        public CAlmacenes()
        {
            BdSolicitudesAlmacenOld = new HashSet<BdSolicitudesAlmacenOld>();
            CSubAlmacenes = new HashSet<CSubAlmacenes>();
        }

        [Key]
        [Column("ID_ALMACEN")]
        public int IdAlmacen { get; set; }
        [Column("DESC_ALMACEN")]
        [StringLength(50)]
        public string DescAlmacen { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("ID_ZONA")]
        public int IdZona { get; set; }
        [Column("IS_LAB")]
        public int IsLab { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("AUTO_NOTIF")]
        public bool? AutoNotif { get; set; }
        [Column("IS_PROPIEDAD_CLIENTE")]
        public int? IsPropiedadCliente { get; set; }
        [Column("ENVIO_EMAIL")]
        public int? EnvioEmail { get; set; }
        [Column("ID_PROVEEDOR")]
        public int? IdProveedor { get; set; }

        [InverseProperty("IdAlmacenNavigation")]
        public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOld { get; set; }
        [InverseProperty("IdParentAlmacenNavigation")]
        public virtual ICollection<CSubAlmacenes> CSubAlmacenes { get; set; }
    }
}
