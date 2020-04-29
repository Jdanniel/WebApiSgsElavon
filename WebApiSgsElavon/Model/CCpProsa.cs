using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CP_PROSA")]
    public partial class CCpProsa
    {
        [Key]
        [Column("ID_CP_PROSA")]
        public int IdCpProsa { get; set; }
        [Column("CP")]
        [StringLength(5)]
        public string Cp { get; set; }
        [Column("ESTADO")]
        [StringLength(30)]
        public string Estado { get; set; }
        [Column("POBLACION")]
        [StringLength(60)]
        public string Poblacion { get; set; }
        [Column("MUNICIPIO")]
        [StringLength(60)]
        public string Municipio { get; set; }
        [Column("COLONIA")]
        [StringLength(100)]
        public string Colonia { get; set; }
        [Column("ZONA")]
        public int? Zona { get; set; }
        [Column("ESTATUS")]
        [StringLength(20)]
        public string Estatus { get; set; }
        [Column("FECHA_CARGA", TypeName = "datetime")]
        public DateTime? FechaCarga { get; set; }
    }
}
