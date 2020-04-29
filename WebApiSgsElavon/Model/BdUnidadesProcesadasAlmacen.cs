using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_UNIDADES_PROCESADAS_ALMACEN")]
    public partial class BdUnidadesProcesadasAlmacen
    {
        [Column("ID_UNIDAD_PROCESADA_ALMACEN")]
        public int IdUnidadProcesadaAlmacen { get; set; }
        [Column("ID_CARGA")]
        public int? IdCarga { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("NO_SERIE")]
        [StringLength(255)]
        public string NoSerie { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("STATUS")]
        [StringLength(255)]
        public string Status { get; set; }
        [Column("SUCCESS")]
        [StringLength(255)]
        public string Success { get; set; }
    }
}
