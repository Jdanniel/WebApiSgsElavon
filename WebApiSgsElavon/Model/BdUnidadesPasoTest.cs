using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_UNIDADES_PASO_TEST")]
    public partial class BdUnidadesPasoTest
    {
        [Column("ID_UNIDAD_PASO_TEST")]
        public int IdUnidadPasoTest { get; set; }
        [Column("NO_SERIE")]
        [StringLength(255)]
        public string NoSerie { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("ID_CONECTIVIDAD")]
        public int? IdConectividad { get; set; }
        [Column("ID_APLICATIVO")]
        public int? IdAplicativo { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int? IdTipoResponsable { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
    }
}
