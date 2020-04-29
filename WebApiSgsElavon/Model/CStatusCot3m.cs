using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_COT_3M")]
    public partial class CStatusCot3m
    {
        [Key]
        [Column("id_status_cot")]
        public int IdStatusCot { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(20)]
        public string Descripcion { get; set; }
    }
}
