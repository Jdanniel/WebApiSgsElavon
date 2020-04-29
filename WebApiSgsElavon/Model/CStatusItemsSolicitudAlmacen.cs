using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_ITEMS_SOLICITUD_ALMACEN")]
    public partial class CStatusItemsSolicitudAlmacen
    {
        [Column("ID_STATUS_ITEMS_SOLICITUD_ALMACEN")]
        public int IdStatusItemsSolicitudAlmacen { get; set; }
        [Column("DESC_STATUS_ITEMS_SOLICITUD_ALMACEN")]
        [StringLength(50)]
        public string DescStatusItemsSolicitudAlmacen { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
