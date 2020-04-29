using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_INGRESO_ARCHIVO_INSUMOS")]
    public partial class BdIngresoArchivoInsumos
    {
        [Column("ID_INGRESO_ARCHIVO_INSUMO")]
        public int IdIngresoArchivoInsumo { get; set; }
        [Column("ID_ARCHIVO")]
        public int? IdArchivo { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("CANTIDAD")]
        public int? Cantidad { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int? IdTipoResponsable { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("ID_STATUS_INSUMO")]
        public int? IdStatusInsumo { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("STATUS_ARCHIVO")]
        [StringLength(50)]
        public string StatusArchivo { get; set; }
        [Column("DESC_ERROR")]
        [StringLength(50)]
        public string DescError { get; set; }
    }
}
