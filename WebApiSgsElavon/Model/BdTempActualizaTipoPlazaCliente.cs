using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_TEMP_ACTUALIZA_TIPO_PLAZA_CLIENTE")]
    public partial class BdTempActualizaTipoPlazaCliente
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("ID_SEGMENTO")]
        public int? IdSegmento { get; set; }
        [Column("ID_TIPO_PLAZA")]
        public int? IdTipoPlaza { get; set; }
        [Column("ID_TIPO_PLAZA_CLIENTE")]
        public int? IdTipoPlazaCliente { get; set; }
    }
}
