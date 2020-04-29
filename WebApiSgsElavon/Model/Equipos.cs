using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("EQUIPOS")]
    public partial class Equipos
    {
        [Key]
        [Column("ID_EQUIPO")]
        public int IdEquipo { get; set; }
        [Column("IDEquipo")]
        public double? Idequipo1 { get; set; }
        [Column("MakeID")]
        [StringLength(255)]
        public string MakeId { get; set; }
        [Column("ModelID")]
        [StringLength(255)]
        public string ModelId { get; set; }
        [StringLength(255)]
        public string SerialNumber { get; set; }
        [Column("CompanyID")]
        public double? CompanyId { get; set; }
        [Column("IDZona")]
        public double? Idzona { get; set; }
        [Column("ReceivingLocID")]
        [StringLength(255)]
        public string ReceivingLocId { get; set; }
        [Column("IDRegional")]
        [StringLength(255)]
        public string Idregional { get; set; }
        [StringLength(255)]
        public string Afiliacion { get; set; }
        [StringLength(255)]
        public string Id { get; set; }
        [StringLength(255)]
        public string Desc { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(255)]
        public string City { get; set; }
        [StringLength(255)]
        public string StateProv { get; set; }
        [StringLength(255)]
        public string ContactName { get; set; }
        [StringLength(255)]
        public string CustomerName { get; set; }
        [StringLength(255)]
        public string PostCode { get; set; }
        [StringLength(255)]
        public string Phone { get; set; }
        public double? StatusEquipo { get; set; }
        [StringLength(255)]
        public string IdUsuario { get; set; }
        [StringLength(255)]
        public string Inventario { get; set; }
        public double? IdSegmento { get; set; }
        [Column("IMEI")]
        [StringLength(255)]
        public string Imei { get; set; }
        [Column("SIMM")]
        [StringLength(255)]
        public string Simm { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        public double? IdOrigen { get; set; }
        public double? IdAlmacen { get; set; }
        public double? IdTipoEquipo { get; set; }
        [Column("AR")]
        public double? Ar { get; set; }
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
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("NO_SERIE")]
        [StringLength(50)]
        public string NoSerie { get; set; }
        [Column("NO_INVENTARIO")]
        [StringLength(50)]
        public string NoInventario { get; set; }
        [Column("ID_SIM")]
        public int? IdSim { get; set; }
        [Column("NO_IMEI")]
        [StringLength(50)]
        public string NoImei { get; set; }
        [Column("NO_SIM")]
        [StringLength(50)]
        public string NoSim { get; set; }
        [Column("NO_EQUIPO")]
        [StringLength(50)]
        public string NoEquipo { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int? IdTipoResponsable { get; set; }
        [Column("ID_RESPONSABLE")]
        [StringLength(10)]
        public string IdResponsable { get; set; }
        [Column("ID_LLAVE")]
        public int? IdLlave { get; set; }
        [Column("ID_SOFTWARE")]
        public int? IdSoftware { get; set; }
        [Column("POSICION_INVENTARIO")]
        [StringLength(50)]
        public string PosicionInventario { get; set; }
        [Column("IS_RETIRO")]
        public int? IsRetiro { get; set; }
        [Column("ID_STATUS_UNIDAD")]
        public int? IdStatusUnidad { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("IS_PROCESSED")]
        public int? IsProcessed { get; set; }
    }
}
