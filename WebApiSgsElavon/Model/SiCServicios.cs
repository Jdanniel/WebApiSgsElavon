using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("SI_C_SERVICIOS")]
    public partial class SiCServicios
    {
        [Key]
        [Column("ID_SERVICIO")]
        public int IdServicio { get; set; }
        [Column("DESC_SERVICIO")]
        [StringLength(60)]
        public string DescServicio { get; set; }
        [Column("ID_TIPO_SERVICIO")]
        public int? IdTipoServicio { get; set; }
        [Column("ID_RESPONSABLE_TECNICO")]
        public int? IdResponsableTecnico { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}
