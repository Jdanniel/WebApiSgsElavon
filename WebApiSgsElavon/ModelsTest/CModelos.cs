using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CModelos
    {
        public CModelos()
        {
            BdBitacoraModeloUnidadIdModeloNuevoNavigation = new HashSet<BdBitacoraModeloUnidad>();
            BdBitacoraModeloUnidadIdModeloViejoNavigation = new HashSet<BdBitacoraModeloUnidad>();
            BdModeloAccesorio = new HashSet<BdModeloAccesorio>();
            BdModeloInsumo = new HashSet<BdModeloInsumo>();
            BdModeloLlave = new HashSet<BdModeloLlave>();
            BdModeloModuloIdModeloModuloNavigation = new HashSet<BdModeloModulo>();
            BdModeloModuloIdModeloNavigation = new HashSet<BdModeloModulo>();
            BdModeloPrecio = new HashSet<BdModeloPrecio>();
            BdModeloSku = new HashSet<BdModeloSku>();
            BdModeloSustitutoIdModeloNavigation = new HashSet<BdModeloSustituto>();
            BdModeloSustitutoIdModeloSustitutoNavigation = new HashSet<BdModeloSustituto>();
            BdSolicitudesDevolucionModelo = new HashSet<BdSolicitudesDevolucionModelo>();
        }

        public int IdModelo { get; set; }
        public string DescModelo { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int? IsGprs { get; set; }
        public decimal? Costo { get; set; }
        public int? IdMonedaCosto { get; set; }
        public string Sku { get; set; }
        public int? IdAttachImagenModelo { get; set; }
        public string Status { get; set; }
        public int? IdAccess { get; set; }
        public string DeviceTypeCategory { get; set; }
        public string DeviceType { get; set; }
        public int? IsItems { get; set; }
        public int? IsConectividad { get; set; }
        public int? IsConjunto { get; set; }
        public int? IsMulticonectividad { get; set; }
        public int? MultiConectividad { get; set; }
        public int? IsReporteSims { get; set; }
        public int? IsContacless { get; set; }
        public int? IdStatusModelo { get; set; }

        public virtual CMonedas IdMonedaCostoNavigation { get; set; }
        public virtual ICollection<BdBitacoraModeloUnidad> BdBitacoraModeloUnidadIdModeloNuevoNavigation { get; set; }
        public virtual ICollection<BdBitacoraModeloUnidad> BdBitacoraModeloUnidadIdModeloViejoNavigation { get; set; }
        public virtual ICollection<BdModeloAccesorio> BdModeloAccesorio { get; set; }
        public virtual ICollection<BdModeloInsumo> BdModeloInsumo { get; set; }
        public virtual ICollection<BdModeloLlave> BdModeloLlave { get; set; }
        public virtual ICollection<BdModeloModulo> BdModeloModuloIdModeloModuloNavigation { get; set; }
        public virtual ICollection<BdModeloModulo> BdModeloModuloIdModeloNavigation { get; set; }
        public virtual ICollection<BdModeloPrecio> BdModeloPrecio { get; set; }
        public virtual ICollection<BdModeloSku> BdModeloSku { get; set; }
        public virtual ICollection<BdModeloSustituto> BdModeloSustitutoIdModeloNavigation { get; set; }
        public virtual ICollection<BdModeloSustituto> BdModeloSustitutoIdModeloSustitutoNavigation { get; set; }
        public virtual ICollection<BdSolicitudesDevolucionModelo> BdSolicitudesDevolucionModelo { get; set; }
    }
}
