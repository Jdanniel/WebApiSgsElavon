using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_DOCTOS_PREFACTURACION")]
    public partial class CStatusDoctosPrefacturacion
    {
        [Column("ID_STATUS_DOCTO_PREFACTURACION")]
        public int IdStatusDoctoPrefacturacion { get; set; }
        [Column("DESC_STATUS_DOCTO_PREFACTURACION")]
        [StringLength(50)]
        public string DescStatusDoctoPrefacturacion { get; set; }
        [Column("IS_DOCTO_FISICO")]
        public int? IsDoctoFisico { get; set; }
        [Column("IS_DOCTO_DIGITAL")]
        public int? IsDoctoDigital { get; set; }
        [Column("IS_INGENIERO_ASSIGN")]
        public int? IsIngenieroAssign { get; set; }
        [Column("IS_SUPERVISOR_ASSIGN")]
        public int? IsSupervisorAssign { get; set; }
        [Column("IS_PREFACTURACION_ASSIGN")]
        public int? IsPrefacturacionAssign { get; set; }
        [Column("IS_PARTNER_ASSIGN")]
        public int? IsPartnerAssign { get; set; }
        [Column("IS_CLIENTE_ASSIGN")]
        public int? IsClienteAssign { get; set; }
        [Column("IS_MODULE_PREFACTURACION")]
        public int? IsModulePrefacturacion { get; set; }
        [Column("IS_MODULE_BUSQUEDA")]
        public int? IsModuleBusqueda { get; set; }
        [Column("IS_MODULE_REPORTE")]
        public int? IsModuleReporte { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}
