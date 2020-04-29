using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_HORAS")]
    public partial class CHoras
    {
        [Key]
        [Column("ID_HORA")]
        public int IdHora { get; set; }
        [Required]
        [Column("NO_HORA")]
        [StringLength(2)]
        public string NoHora { get; set; }
    }
}
