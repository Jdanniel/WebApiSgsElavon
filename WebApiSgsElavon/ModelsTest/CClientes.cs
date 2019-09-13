using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CClientes
    {
        public CClientes()
        {
            BdDevoluciones = new HashSet<BdDevoluciones>();
            BdGruposClientes = new HashSet<BdGruposClientes>();
            BdInstalaciones = new HashSet<BdInstalaciones>();
            BdModeloPrecio = new HashSet<BdModeloPrecio>();
            BdModeloSku = new HashSet<BdModeloSku>();
            BdNegocioHorasMes = new HashSet<BdNegocioHorasMes>();
            BdNegociosAlta = new HashSet<BdNegociosAlta>();
            BdReporteCierre = new HashSet<BdReporteCierre>();
            BdReporteCierreAr = new HashSet<BdReporteCierreAr>();
            BdSparePartPrecio = new HashSet<BdSparePartPrecio>();
        }

        public int IdCliente { get; set; }
        public int? IdProducto { get; set; }
        public string DescCliente { get; set; }
        public string Descripcion { get; set; }
        public decimal? PorRechazo { get; set; }
        public int? IsReparaciones { get; set; }
        public int? IsIdReq { get; set; }
        public int? IsLab { get; set; }
        public int? IsArUpdatesNegocio { get; set; }
        public int? IsNumericNoAfiliacion { get; set; }
        public int? IsNumericNoAr { get; set; }
        public int? IsReporteAr { get; set; }
        public int? IsVisitaCobrable { get; set; }
        public int? IsSingleMovInv { get; set; }
        public int? IsUnidadAtendidaRequired { get; set; }
        public int? IsUptime { get; set; }
        public decimal? PorUptime { get; set; }
        public int? IdTipoCalculoUptime { get; set; }
        public int? IsWincor { get; set; }
        public int? IsInterfazSantander { get; set; }
        public string CadenaWincor { get; set; }
        public string DocTir { get; set; }
        public int? IsRetipificados { get; set; }
        public int? IsPrefacturacion { get; set; }
        public string Status { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public int? IdAccess { get; set; }
        public string CentroCostos { get; set; }
        public string CharCodigoIntervencion { get; set; }
        public int? IsPendienteParte { get; set; }
        public int? IsFacturacionAutomatica { get; set; }
        public int? IsSegmentoDelimitador { get; set; }
        public int? IsCierreMasivo { get; set; }
        public int? IsAsignacionMasiva { get; set; }
        public int? IsArUnico { get; set; }
        public int? Is3X1 { get; set; }
        public int? IsTimeNeeded { get; set; }
        public int? IsValidaTir { get; set; }
        public int? IsElavon { get; set; }
        public int? IsAsignacionAuto { get; set; }
        public int? IsFacturacionIguala { get; set; }
        public int? IsPrecioDoble { get; set; }
        public int? IsOneUnidad { get; set; }
        public int? IsFecGarantiaChange { get; set; }
        public int? IsRetornoAccesorios { get; set; }
        public int? IsSustitucionNoNeeded { get; set; }
        public int? IsPagoIguala { get; set; }
        public int? IsPagoEvento { get; set; }
        public int? NoPoliticaViaticos { get; set; }
        public int? IsWincorTiempo { get; set; }
        public int? IsSendHistory { get; set; }
        public int? IsModifiedAr { get; set; }
        public int? IsEmailServiceCharge { get; set; }
        public int? IsModFecCita { get; set; }
        public int? IsAddReplicate { get; set; }
        public int? IsFecInicioDefault { get; set; }

        public virtual CTipoCalculoUptime IdTipoCalculoUptimeNavigation { get; set; }
        public virtual ICollection<BdDevoluciones> BdDevoluciones { get; set; }
        public virtual ICollection<BdGruposClientes> BdGruposClientes { get; set; }
        public virtual ICollection<BdInstalaciones> BdInstalaciones { get; set; }
        public virtual ICollection<BdModeloPrecio> BdModeloPrecio { get; set; }
        public virtual ICollection<BdModeloSku> BdModeloSku { get; set; }
        public virtual ICollection<BdNegocioHorasMes> BdNegocioHorasMes { get; set; }
        public virtual ICollection<BdNegociosAlta> BdNegociosAlta { get; set; }
        public virtual ICollection<BdReporteCierre> BdReporteCierre { get; set; }
        public virtual ICollection<BdReporteCierreAr> BdReporteCierreAr { get; set; }
        public virtual ICollection<BdSparePartPrecio> BdSparePartPrecio { get; set; }
    }
}
