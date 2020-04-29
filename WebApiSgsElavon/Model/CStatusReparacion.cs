using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_REPARACION")]
    public partial class CStatusReparacion
    {
        [Key]
        [Column("ID_STATUS_REPARACION")]
        public int IdStatusReparacion { get; set; }
        [Column("DESC_STATUS_REPARACION")]
        [StringLength(50)]
        public string DescStatusReparacion { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}
