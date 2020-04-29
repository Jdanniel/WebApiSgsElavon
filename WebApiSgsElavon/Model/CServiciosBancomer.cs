using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_SERVICIOS_BANCOMER")]
    public partial class CServiciosBancomer
    {
        [Column("ID_SERVICIO")]
        public int IdServicio { get; set; }
        [Column("DESC_SERVICIO")]
        [StringLength(50)]
        public string DescServicio { get; set; }
        [Column("MOV")]
        [StringLength(1)]
        public string Mov { get; set; }
    }
}
