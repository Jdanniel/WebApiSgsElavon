using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CModelo
{
    public int IdModelo { get; set; }

    public string DescModelo { get; set; }

    public string Descripcion { get; set; }

    public int? IdMarca { get; set; }

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

    public virtual ICollection<BdBitacoraModeloUnidad> BdBitacoraModeloUnidadIdModeloNuevoNavigations { get; set; } = new List<BdBitacoraModeloUnidad>();

    public virtual ICollection<BdBitacoraModeloUnidad> BdBitacoraModeloUnidadIdModeloViejoNavigations { get; set; } = new List<BdBitacoraModeloUnidad>();

    public virtual ICollection<BdModeloAccesorio> BdModeloAccesorios { get; set; } = new List<BdModeloAccesorio>();

    public virtual ICollection<BdModeloInsumo> BdModeloInsumos { get; set; } = new List<BdModeloInsumo>();

    public virtual ICollection<BdModeloLlave> BdModeloLlaves { get; set; } = new List<BdModeloLlave>();

    public virtual ICollection<BdModeloModulo> BdModeloModuloIdModeloModuloNavigations { get; set; } = new List<BdModeloModulo>();

    public virtual ICollection<BdModeloModulo> BdModeloModuloIdModeloNavigations { get; set; } = new List<BdModeloModulo>();

    public virtual ICollection<BdModeloPrecio> BdModeloPrecios { get; set; } = new List<BdModeloPrecio>();

    public virtual ICollection<BdModeloSku> BdModeloSkus { get; set; } = new List<BdModeloSku>();

    public virtual ICollection<BdModeloSustituto> BdModeloSustitutoIdModeloNavigations { get; set; } = new List<BdModeloSustituto>();

    public virtual ICollection<BdModeloSustituto> BdModeloSustitutoIdModeloSustitutoNavigations { get; set; } = new List<BdModeloSustituto>();

    public virtual ICollection<BdSolicitudesDevolucionModelo> BdSolicitudesDevolucionModelos { get; set; } = new List<BdSolicitudesDevolucionModelo>();

    public virtual CMoneda IdMonedaCostoNavigation { get; set; }
}
