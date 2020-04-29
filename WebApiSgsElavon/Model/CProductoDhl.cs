using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("c_producto_dhl")]
    public partial class CProductoDhl
    {
        [Column("id_producto_dhl")]
        public int IdProductoDhl { get; set; }
        [Column("nom_producto_dhl")]
        [StringLength(10)]
        public string NomProductoDhl { get; set; }
        [Column("desc_producto_dhl")]
        [StringLength(50)]
        public string DescProductoDhl { get; set; }
        [Column("status")]
        [StringLength(20)]
        public string Status { get; set; }
    }
}
