using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUDES_DEVOLUCION")]
    public partial class BdSolicitudesDevolucion
    {
        [Key]
        [Column("ID_SOLICITUD_DEVOLUCION")]
        public int IdSolicitudDevolucion { get; set; }
        [Column("ID_SOLICITANTE")]
        public int? IdSolicitante { get; set; }
        [Column("ID_ALMACEN")]
        public int? IdAlmacen { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_SERVICIO_MENSAJERIA")]
        public int? IdServicioMensajeria { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("ID_ENVIO")]
        public int? IdEnvio { get; set; }
        [Column("ID_UNIDAD_MENSAJERIA")]
        public int? IdUnidadMensajeria { get; set; }
        [Column("ID_CHOFER")]
        public int? IdChofer { get; set; }
        [Column("NO_UNIDADES")]
        public int? NoUnidades { get; set; }
        [Column("CALLE_NUM")]
        [StringLength(255)]
        public string CalleNum { get; set; }
        [Column("COLONIA")]
        [StringLength(255)]
        public string Colonia { get; set; }
        [Column("DELEGACION")]
        [StringLength(255)]
        public string Delegacion { get; set; }
        [Column("CIUDAD")]
        [StringLength(255)]
        public string Ciudad { get; set; }
        [Column("ESTADO")]
        [StringLength(255)]
        public string Estado { get; set; }
        [Column("CP")]
        [StringLength(50)]
        public string Cp { get; set; }
        [Column("FEC_DEVOLUCION", TypeName = "smalldatetime")]
        public DateTime? FecDevolucion { get; set; }
        [Column("HORA_DEVOLUCION", TypeName = "datetime")]
        public DateTime? HoraDevolucion { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_STATUS_SOLICITUD_DEVOLUCION")]
        public int? IdStatusSolicitudDevolucion { get; set; }
        [Column("NOTAS")]
        [StringLength(250)]
        public string Notas { get; set; }
        [Column("INSUMOS")]
        public int? Insumos { get; set; }
        [Column("ACCESORIOS")]
        public int? Accesorios { get; set; }
        [Column("SPARE_PARTS")]
        public int? SpareParts { get; set; }
        [Column("REFACCIONES")]
        public int? Refacciones { get; set; }
        [Column("NO_SIMS")]
        public int? NoSims { get; set; }
        [Column("ID_STATUS_VALIDACION_DEVOLUCION")]
        public int? IdStatusValidacionDevolucion { get; set; }
    }
}
