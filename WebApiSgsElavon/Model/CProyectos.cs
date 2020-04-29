using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_PROYECTOS")]
    public partial class CProyectos
    {
        [Column("ID_PROYECTO")]
        public int IdProyecto { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("DESC_PROYECTO")]
        [StringLength(250)]
        public string DescProyecto { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(400)]
        public string Descripcion { get; set; }
        [Column("NUM_UNIDADES")]
        public int? NumUnidades { get; set; }
        [Column("FEC_INICIO", TypeName = "smalldatetime")]
        public DateTime? FecInicio { get; set; }
        [Column("FEC_GARANTIA", TypeName = "smalldatetime")]
        public DateTime? FecGarantia { get; set; }
        [Column("STATUS")]
        [StringLength(20)]
        public string Status { get; set; }
    }
}
