using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CARGA_ENVIOS_DHL_PASO")]
    public partial class BdCargaEnviosDhlPaso
    {
        [Column("ID_CARGA_ENVIO_DHL")]
        public int IdCargaEnvioDhl { get; set; }
        [Column("ID_CARGA")]
        public int? IdCarga { get; set; }
        [Column("NO_GUIA")]
        public string NoGuia { get; set; }
        [Column("NO_REFERENCIA")]
        [StringLength(255)]
        public string NoReferencia { get; set; }
        [Column("PRODUCTO")]
        [StringLength(50)]
        public string Producto { get; set; }
        [Column("ORG")]
        [StringLength(50)]
        public string Org { get; set; }
        [Column("DES")]
        [StringLength(50)]
        public string Des { get; set; }
        [Column("PZA")]
        public int? Pza { get; set; }
        [Column("KILOS", TypeName = "decimal(8, 2)")]
        public decimal? Kilos { get; set; }
        [Column("FEC_ENVIO", TypeName = "datetime")]
        public DateTime? FecEnvio { get; set; }
        [Column("NO_FACTURA")]
        [StringLength(255)]
        public string NoFactura { get; set; }
        [Column("FLETES", TypeName = "decimal(8, 2)")]
        public decimal? Fletes { get; set; }
        [Column("SEGURO", TypeName = "decimal(8, 2)")]
        public decimal? Seguro { get; set; }
        [Column("FF", TypeName = "decimal(8, 2)")]
        public decimal? Ff { get; set; }
        [Column("YE")]
        public int? Ye { get; set; }
        [Column("OO", TypeName = "decimal(8, 2)")]
        public decimal? Oo { get; set; }
        [Column("DESCUENTO", TypeName = "decimal(8, 2)")]
        public decimal? Descuento { get; set; }
        [Column("IMP_IVA", TypeName = "decimal(8, 2)")]
        public decimal? ImpIva { get; set; }
        [Column("IMPORTE_NETO", TypeName = "decimal(8, 2)")]
        public decimal? ImporteNeto { get; set; }
        [Column("ZONA_PROD")]
        [StringLength(50)]
        public string ZonaProd { get; set; }
        [Column("IVA", TypeName = "decimal(8, 2)")]
        public decimal? Iva { get; set; }
        [Column("MONEDA")]
        [StringLength(50)]
        public string Moneda { get; set; }
        [Column("REMITENTE")]
        [StringLength(255)]
        public string Remitente { get; set; }
        [Column("DESTINATARIO")]
        [StringLength(255)]
        public string Destinatario { get; set; }
        [Column("PROYECTO")]
        [StringLength(255)]
        public string Proyecto { get; set; }
        [Column("REGION")]
        [StringLength(255)]
        public string Region { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("IS_PROCESADO")]
        public int? IsProcesado { get; set; }
    }
}
