using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_PESTANAS_BITACORA_AR")]
    public partial class BdPestanasBitacoraAr
    {
        [Key]
        [Column("ID_PESTANAS_BITACORA_AR")]
        public int IdPestanasBitacoraAr { get; set; }
        [Column("NOMBRE_PESTANA")]
        [StringLength(250)]
        public string NombrePestana { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
