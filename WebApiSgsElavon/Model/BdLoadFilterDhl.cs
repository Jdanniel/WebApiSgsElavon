using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_LOAD_FILTER_DHL")]
    public partial class BdLoadFilterDhl
    {
        [Column("ID_LOAD_FILTER_DHL")]
        public int IdLoadFilterDhl { get; set; }
        [Column("ID_SERVICIO_MENSAJERIA_PRECIO")]
        public int? IdServicioMensajeriaPrecio { get; set; }
        [Column("ID_CARGA")]
        public int? IdCarga { get; set; }
        [Column("ID_ENVIO")]
        public int? IdEnvio { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_REGION")]
        public int? IdRegion { get; set; }
        [Column("CLIENTE")]
        [StringLength(255)]
        public string Cliente { get; set; }
        [Column("REGION")]
        [StringLength(255)]
        public string Region { get; set; }
        [Column("NO_GUIA")]
        [StringLength(255)]
        public string NoGuia { get; set; }
        [Column("COSTO_SGS", TypeName = "decimal(8, 2)")]
        public decimal? CostoSgs { get; set; }
        [Column("ID_CARGA_ENVIO_DHL")]
        public int? IdCargaEnvioDhl { get; set; }
    }
}
