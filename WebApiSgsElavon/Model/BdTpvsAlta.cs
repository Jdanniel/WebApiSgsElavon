using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_TPVS_ALTA")]
    public partial class BdTpvsAlta
    {
        [Key]
        [Column("ID_TPV_ALTA")]
        public int IdTpvAlta { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_SOLICITUD_RECOLECCION")]
        public int? IdSolicitudRecoleccion { get; set; }
        [Column("ID_RESPONSABLE")]
        public int IdResponsable { get; set; }
        [Column("ID_MODELO")]
        public int IdModelo { get; set; }
        [Column("NO_SERIE")]
        [StringLength(50)]
        public string NoSerie { get; set; }
        [Column("NO_INVENTARIO")]
        [StringLength(50)]
        public string NoInventario { get; set; }
        [Column("IS_NUEVA")]
        public int? IsNueva { get; set; }
        [Column("NO_IMEI")]
        [StringLength(50)]
        public string NoImei { get; set; }
        [Column("NO_SIM")]
        [StringLength(50)]
        public string NoSim { get; set; }
        [Column("IS_NULL_CLIENTE")]
        public int? IsNullCliente { get; set; }
        [Column("IS_NULL_NO_SERIE")]
        public int? IsNullNoSerie { get; set; }
        [Column("IS_NULL_NO_IMEI")]
        public int? IsNullNoImei { get; set; }
        [Column("IS_NULL_NO_SIM")]
        public int? IsNullNoSim { get; set; }
        [Column("IS_NULL_NUEVA")]
        public int? IsNullNueva { get; set; }
        [Column("IS_ASIGNADA")]
        public int? IsAsignada { get; set; }
        [Column("IS_GPRS")]
        public int? IsGprs { get; set; }
        [Column("IS_REINGRESO")]
        public int? IsReingreso { get; set; }
        [Column("EXISTS_SIM")]
        public int? ExistsSim { get; set; }
        [Column("EXISTS_MODELO")]
        public int? ExistsModelo { get; set; }
        [Column("IS_PROCESADA")]
        public int? IsProcesada { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_MODELO_ANT")]
        public int? IdModeloAnt { get; set; }
        [Column("IS_CAMBIO_MODELO")]
        public int? IsCambioModelo { get; set; }
        [Column("ID_CONECTIVIDAD")]
        public int? IdConectividad { get; set; }
        [Column("ID_APLICATIVO")]
        public int? IdAplicativo { get; set; }
        [Column("IS_NULL_CONECTIVIDAD")]
        public int? IsNullConectividad { get; set; }
        [Column("IS_NULL_APLICATIVO")]
        public int? IsNullAplicativo { get; set; }
        [Column("ID_ORDEN_COMPRA")]
        public int? IdOrdenCompra { get; set; }
        [Column("IS_ERROR_SERIE")]
        public int? IsErrorSerie { get; set; }
        [Column("MSG_ERROR_SERIE")]
        public string MsgErrorSerie { get; set; }
        [Column("ID_CARGA")]
        public int? IdCarga { get; set; }
    }
}
