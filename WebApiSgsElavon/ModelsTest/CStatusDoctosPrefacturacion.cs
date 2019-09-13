using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CStatusDoctosPrefacturacion
    {
        public int IdStatusDoctoPrefacturacion { get; set; }
        public string DescStatusDoctoPrefacturacion { get; set; }
        public int? IsDoctoFisico { get; set; }
        public int? IsDoctoDigital { get; set; }
        public int? IsIngenieroAssign { get; set; }
        public int? IsSupervisorAssign { get; set; }
        public int? IsPrefacturacionAssign { get; set; }
        public int? IsPartnerAssign { get; set; }
        public int? IsClienteAssign { get; set; }
        public int? IsModulePrefacturacion { get; set; }
        public int? IsModuleBusqueda { get; set; }
        public int? IsModuleReporte { get; set; }
        public string Status { get; set; }
    }
}
