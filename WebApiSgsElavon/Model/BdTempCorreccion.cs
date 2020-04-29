using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_TEMP_CORRECCION")]
    public partial class BdTempCorreccion
    {
        [Key]
        [Column("ID_TEMP_CORRECCION")]
        public int IdTempCorreccion { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("NO_SERIE_OK")]
        [StringLength(50)]
        public string NoSerieOk { get; set; }
        [Column("NO_SERIE_MAL")]
        [StringLength(50)]
        public string NoSerieMal { get; set; }
        [Column("NO_AFILIACION")]
        [StringLength(50)]
        public string NoAfiliacion { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_NEGOCIO")]
        public int? IdNegocio { get; set; }
        [Column("DESC_NEGOCIO")]
        [StringLength(500)]
        public string DescNegocio { get; set; }
    }
}
