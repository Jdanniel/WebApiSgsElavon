using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MC_RUTAS")]
    public partial class CMcRutas
    {
        [Column("ID_RUTA")]
        public int IdRuta { get; set; }
        [Column("DESC_NOMBRE")]
        [StringLength(100)]
        public string DescNombre { get; set; }
        [Column("POBLACION_ORIGEN")]
        [StringLength(50)]
        public string PoblacionOrigen { get; set; }
        [Column("ESTADO_ORIGEN")]
        [StringLength(50)]
        public string EstadoOrigen { get; set; }
        [Column("POBLACION_DESTINO")]
        [StringLength(50)]
        public string PoblacionDestino { get; set; }
        [Column("ESTADO_DESTINO")]
        [StringLength(50)]
        public string EstadoDestino { get; set; }
        [Column("ESTATUS")]
        [StringLength(10)]
        public string Estatus { get; set; }
    }
}
