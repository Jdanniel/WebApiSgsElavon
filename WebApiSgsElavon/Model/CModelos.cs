using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MODELOS")]
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

        [Key]
        [Column("ID_MODELO")]
        public int IdModelo { get; set; }
        [Column("DESC_MODELO")]
        [StringLength(50)]
        public string DescModelo { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(150)]
        public string Descripcion { get; set; }
        [Column("ID_MARCA")]
        public int IdMarca { get; set; }
        [Column("IS_GPRS")]
        public int? IsGprs { get; set; }
        [Column("COSTO", TypeName = "numeric(18, 2)")]
        public decimal? Costo { get; set; }
        [Column("ID_MONEDA_COSTO")]
        public int? IdMonedaCosto { get; set; }
        [Column("SKU")]
        [StringLength(50)]
        public string Sku { get; set; }
        [Column("ID_ATTACH_IMAGEN_MODELO")]
        public int? IdAttachImagenModelo { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_ACCESS")]
        public int? IdAccess { get; set; }
        [Column("device_type_category")]
        [StringLength(250)]
        public string DeviceTypeCategory { get; set; }
        [Column("device_type")]
        [StringLength(250)]
        public string DeviceType { get; set; }
        [Column("IS_ITEMS")]
        public int? IsItems { get; set; }
        [Column("IS_CONECTIVIDAD")]
        public int? IsConectividad { get; set; }
        [Column("IS_CONJUNTO")]
        public int? IsConjunto { get; set; }
        [Column("IS_MULTICONECTIVIDAD")]
        public int? IsMulticonectividad { get; set; }
        [Column("MULTI_CONECTIVIDAD")]
        public int? MultiConectividad { get; set; }
        [Column("IS_REPORTE_SIMS")]
        public int? IsReporteSims { get; set; }
        [Column("IS_CONTACLESS")]
        public int? IsContacless { get; set; }
        [Column("ID_STATUS_MODELO")]
        public int? IdStatusModelo { get; set; }

        [ForeignKey("IdMonedaCosto")]
        [InverseProperty("CModelos")]
        public virtual CMonedas IdMonedaCostoNavigation { get; set; }
        [InverseProperty("IdModeloNuevoNavigation")]
        public virtual ICollection<BdBitacoraModeloUnidad> BdBitacoraModeloUnidadIdModeloNuevoNavigation { get; set; }
        [InverseProperty("IdModeloViejoNavigation")]
        public virtual ICollection<BdBitacoraModeloUnidad> BdBitacoraModeloUnidadIdModeloViejoNavigation { get; set; }
        [InverseProperty("IdModeloNavigation")]
        public virtual ICollection<BdModeloAccesorio> BdModeloAccesorio { get; set; }
        [InverseProperty("IdModeloNavigation")]
        public virtual ICollection<BdModeloInsumo> BdModeloInsumo { get; set; }
        [InverseProperty("IdModeloNavigation")]
        public virtual ICollection<BdModeloLlave> BdModeloLlave { get; set; }
        [InverseProperty("IdModeloModuloNavigation")]
        public virtual ICollection<BdModeloModulo> BdModeloModuloIdModeloModuloNavigation { get; set; }
        [InverseProperty("IdModeloNavigation")]
        public virtual ICollection<BdModeloModulo> BdModeloModuloIdModeloNavigation { get; set; }
        [InverseProperty("IdModeloNavigation")]
        public virtual ICollection<BdModeloPrecio> BdModeloPrecio { get; set; }
        [InverseProperty("IdModeloNavigation")]
        public virtual ICollection<BdModeloSku> BdModeloSku { get; set; }
        [InverseProperty("IdModeloNavigation")]
        public virtual ICollection<BdModeloSustituto> BdModeloSustitutoIdModeloNavigation { get; set; }
        [InverseProperty("IdModeloSustitutoNavigation")]
        public virtual ICollection<BdModeloSustituto> BdModeloSustitutoIdModeloSustitutoNavigation { get; set; }
        [InverseProperty("IdModeloNavigation")]
        public virtual ICollection<BdSolicitudesDevolucionModelo> BdSolicitudesDevolucionModelo { get; set; }
    }
}
