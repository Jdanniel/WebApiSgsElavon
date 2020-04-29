using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CARGA_ENVIOS_ESTAFETA_PASO")]
    public partial class BdCargaEnviosEstafetaPaso
    {
        [Column("ID_CARGA_ENVIO_ESTAFETA_PASO")]
        public int IdCargaEnvioEstafetaPaso { get; set; }
        [Column("ID_CARGA")]
        public int? IdCarga { get; set; }
        [Column("GUIA")]
        [StringLength(255)]
        public string Guia { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("ORIG")]
        [StringLength(255)]
        public string Orig { get; set; }
        [Column("DEST")]
        [StringLength(255)]
        public string Dest { get; set; }
        [Column("ZONA")]
        public int? Zona { get; set; }
        [Column("PESO", TypeName = "decimal(8, 2)")]
        public decimal? Peso { get; set; }
        [Column("SOBREPESO", TypeName = "decimal(8, 2)")]
        public decimal? Sobrepeso { get; set; }
        [Column("DIF_KILOS", TypeName = "decimal(8, 2)")]
        public decimal? DifKilos { get; set; }
        [Column("PESO_FACTURA", TypeName = "decimal(8, 2)")]
        public decimal? PesoFactura { get; set; }
        [Column("LARGO_CM")]
        public int? LargoCm { get; set; }
        [Column("ANCHO_CM")]
        public int? AnchoCm { get; set; }
        [Column("ALTO_CM")]
        public int? AltoCm { get; set; }
        [Column("VOL_REAL")]
        [StringLength(50)]
        public string VolReal { get; set; }
        [Column("MTO_SERV", TypeName = "decimal(8, 2)")]
        public decimal? MtoServ { get; set; }
        [Column("MONTO_SP", TypeName = "decimal(8, 2)")]
        public decimal? MontoSp { get; set; }
        [Column("MTO_CB_SERV", TypeName = "decimal(8, 2)")]
        public decimal? MtoCbServ { get; set; }
        [Column("FEC_ENTREGA", TypeName = "datetime")]
        public DateTime? FecEntrega { get; set; }
        [Column("TIEMPO_ENTREGA")]
        public int? TiempoEntrega { get; set; }
        [Column("RECIBE")]
        [StringLength(255)]
        public string Recibe { get; set; }
        [Column("TIPO_EMPAQUE")]
        [StringLength(255)]
        public string TipoEmpaque { get; set; }
        [Column("REFERENCIA")]
        [StringLength(255)]
        public string Referencia { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("IS_PROCESADO")]
        public int? IsProcesado { get; set; }
    }
}
