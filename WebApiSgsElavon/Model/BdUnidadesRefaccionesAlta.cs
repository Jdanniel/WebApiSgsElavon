using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_UNIDADES_REFACCIONES_ALTA")]
    public partial class BdUnidadesRefaccionesAlta
    {
        [Column("ID_UNIDAD_REFACCION_ALTA")]
        public int IdUnidadRefaccionAlta { get; set; }
        [Column("ID_PARENT")]
        public int? IdParent { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_SOLICITUD_RECOLECCION")]
        public int? IdSolicitudRecoleccion { get; set; }
        [Column("ID_PRODUCTO")]
        public int? IdProducto { get; set; }
        [Column("IS_NUEVA")]
        public int? IsNueva { get; set; }
        [Column("ID_MARCA")]
        public int IdMarca { get; set; }
        [Column("ID_MODELO")]
        public int IdModelo { get; set; }
        [Required]
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
        public int? IdResponsable { get; set; }
        [Column("ID_LLAVE")]
        public int? IdLlave { get; set; }
        [Column("ID_SOFTWARE")]
        public int? IdSoftware { get; set; }
        [Column("POSICION_INVENTARIO")]
        [StringLength(50)]
        public string PosicionInventario { get; set; }
        [Column("IS_RETIRO")]
        public int? IsRetiro { get; set; }
        [Column("IS_DANIADA")]
        public int? IsDaniada { get; set; }
        [Column("COSTO", TypeName = "numeric(18, 2)")]
        public decimal? Costo { get; set; }
        [Column("ID_MONEDA")]
        public int? IdMoneda { get; set; }
        [Column("ID_STATUS_UNIDAD")]
        public int IdStatusUnidad { get; set; }
        [Column("IS_PROPIEDAD_CLIENTE")]
        public int? IsPropiedadCliente { get; set; }
        [Column("IS_LISTA_NO_SERIE_DUPLICADA")]
        public int? IsListaNoSerieDuplicada { get; set; }
        [Column("IS_NO_SERIE_DUPLICADA")]
        public int? IsNoSerieDuplicada { get; set; }
        [Column("IS_DATO_NULO")]
        [StringLength(10)]
        public string IsDatoNulo { get; set; }
        [Column("IS_PROCESADA")]
        public int? IsProcesada { get; set; }
        [Column("NECESITA_COSTO_O_ID_MONEDA")]
        public int? NecesitaCostoOIdMoneda { get; set; }
    }
}
