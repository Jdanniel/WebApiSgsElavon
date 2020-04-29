using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_INGRESO_ARCHIVOS_ALMACEN")]
    public partial class BdIngresoArchivosAlmacen
    {
        [Key]
        [Column("ID_ARCHIVO_ALMACEN")]
        public int IdArchivoAlmacen { get; set; }
        [Column("ID_ARCHIVO")]
        public int? IdArchivo { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("ID_MARCA")]
        public int? IdMarca { get; set; }
        [Column("SERIE")]
        [StringLength(50)]
        public string Serie { get; set; }
        [Column("NO_SIM")]
        [StringLength(50)]
        public string NoSim { get; set; }
        [Column("NO_IMEI")]
        [StringLength(50)]
        public string NoImei { get; set; }
        [Column("ID_CARRIER")]
        public int? IdCarrier { get; set; }
        [Column("FECHA_COMPRA", TypeName = "smalldatetime")]
        public DateTime? FechaCompra { get; set; }
        [Column("ID_TIPO_CONEXION")]
        public int? IdTipoConexion { get; set; }
        [Column("ID_TIPO_TERMINAL")]
        public int? IdTipoTerminal { get; set; }
        [Column("ID_APLICATIVO")]
        public int? IdAplicativo { get; set; }
        [Column("CATEGORIA")]
        public int? Categoria { get; set; }
        [Column("ID_FABRICANTE")]
        public int? IdFabricante { get; set; }
        [Column("VERSION_APLICATIVO")]
        [StringLength(50)]
        public string VersionAplicativo { get; set; }
        [Column("VERSION_KERNEL")]
        [StringLength(50)]
        public string VersionKernel { get; set; }
        [Column("FECHA_VENCIMIENTO_KERNEL", TypeName = "smalldatetime")]
        public DateTime? FechaVencimientoKernel { get; set; }
        [Column("STATUS_ARCHIVO")]
        [StringLength(50)]
        public string StatusArchivo { get; set; }
        [Column("ID_USUARIO_ALTA_ARCHIVO")]
        public int? IdUsuarioAltaArchivo { get; set; }
        [Column("FECHA_ALTA_ARCHIVO", TypeName = "smalldatetime")]
        public DateTime? FechaAltaArchivo { get; set; }
        [Column("DESC_ERROR")]
        [StringLength(500)]
        public string DescError { get; set; }
        [Column("IS_SIM")]
        public int? IsSim { get; set; }
        [Column("ID_TIPO_RESPONSABLE_DESTINO")]
        public int? IdTipoResponsableDestino { get; set; }
        [Column("ID_RESPONSABLE_DESTINO")]
        public int? IdResponsableDestino { get; set; }
        [Column("ID_CONECTIVIDAD")]
        public int? IdConectividad { get; set; }
    }
}
