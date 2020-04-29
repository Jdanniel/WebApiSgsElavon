using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MINUTOS")]
    public partial class CMinutos
    {
        [Key]
        [Column("ID_MINUTO")]
        public int IdMinuto { get; set; }
        [Required]
        [Column("NO_MINUTO")]
        [StringLength(2)]
        public string NoMinuto { get; set; }
    }
}
