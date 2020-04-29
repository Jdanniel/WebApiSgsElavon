using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_SUB_ALMACENES")]
    public partial class CSubAlmacenes
    {
        [Column("ID_C_SUB_ALMACENES")]
        public int IdCSubAlmacenes { get; set; }
        [Column("DESC_SUB_ALMACEN")]
        [StringLength(50)]
        public string DescSubAlmacen { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("ID_PARENT_ALMACEN")]
        public int? IdParentAlmacen { get; set; }
        [Column("ID_ZONA")]
        public int? IdZona { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }

        [ForeignKey("IdParentAlmacen")]
        [InverseProperty("CSubAlmacenes")]
        public virtual CAlmacenes IdParentAlmacenNavigation { get; set; }
    }
}
