using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_ORDEN_COMPRA")]
    public partial class CStatusOrdenCompra
    {
        [Column("ID_STATUS_ORDEN_COMPRA")]
        public int IdStatusOrdenCompra { get; set; }
        [Column("DESC_STATUS")]
        [StringLength(255)]
        public string DescStatus { get; set; }
        [Column("STATUS")]
        [StringLength(255)]
        public string Status { get; set; }
    }
}
