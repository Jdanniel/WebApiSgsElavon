using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("UNIDADES_BNM_ATM")]
    public partial class UnidadesBnmAtm
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_PARENT")]
        public int? IdParent { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_SOLICITUD_RECOLECCION")]
        public int? IdSolicitudRecoleccion { get; set; }
        [Column("ID_PRODUCTO")]
        public int? IdProducto { get; set; }
        [Column("IS_NUEVA")]
        public int? IsNueva { get; set; }
        [Column("ID_MARCA")]
        public int? IdMarca { get; set; }
        [StringLength(255)]
        public string Modelo { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("NO_SERIE")]
        [StringLength(255)]
        public string NoSerie { get; set; }
        [Column("NO_INVENTARIO")]
        [StringLength(255)]
        public string NoInventario { get; set; }
        [Column("ID_SIM")]
        public int? IdSim { get; set; }
        [Column("NO_SIM")]
        [StringLength(255)]
        public string NoSim { get; set; }
        [Column("NO_IMEI")]
        [StringLength(255)]
        public string NoImei { get; set; }
        [Column("NO_EQUIPO")]
        [StringLength(255)]
        public string NoEquipo { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int? IdTipoResponsable { get; set; }
        [Column("NO_AFILIACION")]
        [StringLength(255)]
        public string NoAfiliacion { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("ID_LLAVE")]
        public int? IdLlave { get; set; }
        [Column("ID_SOFTWARE")]
        public int? IdSoftware { get; set; }
        [Column("POSICION_INV")]
        [StringLength(255)]
        public string PosicionInv { get; set; }
        [Column("IS_RETIRO")]
        public int? IsRetiro { get; set; }
        [Column("IS_DANIADA")]
        public int? IsDaniada { get; set; }
        [Column("ID_STATUS_UNIDAD")]
        public int? IdStatusUnidad { get; set; }
        [Column("STATUS")]
        [StringLength(255)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("IS_DUPLICADO_LISTA")]
        public int? IsDuplicadoLista { get; set; }
        [Column("IS_SYSTEMA")]
        public int? IsSystema { get; set; }
        [Column("IS_ERROR_AFILIACION")]
        public int? IsErrorAfiliacion { get; set; }
    }
}
