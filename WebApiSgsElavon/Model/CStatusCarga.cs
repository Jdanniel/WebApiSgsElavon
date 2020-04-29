using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_CARGA")]
    public partial class CStatusCarga
    {
        [Column("ID_STATUS_CARGA")]
        public int IdStatusCarga { get; set; }
        [Column("DESC_STATUS_CARGA")]
        [StringLength(50)]
        public string DescStatusCarga { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}
