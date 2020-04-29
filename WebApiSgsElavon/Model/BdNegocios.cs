using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_NEGOCIOS")]
    public partial class BdNegocios
    {
        public BdNegocios()
        {
            BdInstalaciones = new HashSet<BdInstalaciones>();
            BdNegocioHorasMes = new HashSet<BdNegocioHorasMes>();
            BdRetiros = new HashSet<BdRetiros>();
            BdSustituciones = new HashSet<BdSustituciones>();
        }

        [Key]
        [Column("ID_NEGOCIO")]
        public int IdNegocio { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_REGION")]
        public int? IdRegion { get; set; }
        [Column("ID_ZONA")]
        public int? IdZona { get; set; }
        [Column("ID_SEGMENTO")]
        public int? IdSegmento { get; set; }
        [Column("DESC_NEGOCIO")]
        [StringLength(255)]
        public string DescNegocio { get; set; }
        [Column("NO_AFILIACION")]
        [StringLength(50)]
        public string NoAfiliacion { get; set; }
        [Column("TELEFONO")]
        [StringLength(50)]
        public string Telefono { get; set; }
        [Column("DIRECCION")]
        [StringLength(255)]
        public string Direccion { get; set; }
        [Column("COLONIA")]
        [StringLength(255)]
        public string Colonia { get; set; }
        [Column("POBLACION")]
        [StringLength(255)]
        public string Poblacion { get; set; }
        [Column("ESTADO")]
        [StringLength(255)]
        public string Estado { get; set; }
        [Column("ID_ESTADO")]
        public int? IdEstado { get; set; }
        [Column("CP")]
        [StringLength(6)]
        public string Cp { get; set; }
        [Column("ID_HORARIO_UPTIME")]
        public int? IdHorarioUptime { get; set; }
        [Column("ID_HORARIO_ACCESO")]
        public int? IdHorarioAcceso { get; set; }
        [Column("ID_CARGA_ALTA")]
        public int? IdCargaAlta { get; set; }
        [Column("ID_CARGA_STATUS")]
        public int? IdCargaStatus { get; set; }
        [Column("LATITUD", TypeName = "numeric(20, 15)")]
        public decimal? Latitud { get; set; }
        [Column("LONGITUD", TypeName = "numeric(20, 15)")]
        public decimal? Longitud { get; set; }
        [Column("GRADO_ERROR", TypeName = "numeric(20, 10)")]
        public decimal? GradoError { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_UPDATE")]
        public int? IdUsuarioUpdate { get; set; }
        [Column("FEC_UPDATE", TypeName = "smalldatetime")]
        public DateTime? FecUpdate { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("PRECIO", TypeName = "numeric(18, 2)")]
        public decimal? Precio { get; set; }
        [Column("ID_TIPO_COBRO_NEGOCIO")]
        public int? IdTipoCobroNegocio { get; set; }
        [Column("ID_MONEDA")]
        public int? IdMoneda { get; set; }
        [Column("RAZON_SOCIAL")]
        [StringLength(250)]
        public string RazonSocial { get; set; }
        [Column("NOMBRE_FISCAL")]
        [StringLength(250)]
        public string NombreFiscal { get; set; }
        [Column("RFC_FISCAL")]
        [StringLength(250)]
        public string RfcFiscal { get; set; }
        [Column("CALLE_NUM_FISCAL")]
        [StringLength(250)]
        public string CalleNumFiscal { get; set; }
        [Column("CP_FISCAL")]
        [StringLength(5)]
        public string CpFiscal { get; set; }
        [Column("COLONIA_FISCAL")]
        [StringLength(250)]
        public string ColoniaFiscal { get; set; }
        [Column("POBLACION_FISCAL")]
        [StringLength(250)]
        public string PoblacionFiscal { get; set; }
        [Column("ID_ESTADO_FISCAL")]
        [StringLength(250)]
        public string IdEstadoFiscal { get; set; }
        [Column("FEC_ALTA_IGUALA", TypeName = "smalldatetime")]
        public DateTime? FecAltaIguala { get; set; }
        [Column("FEC_BAJA_IGUALA", TypeName = "smalldatetime")]
        public DateTime? FecBajaIguala { get; set; }
        [Column("APROXIMADO")]
        public int? Aproximado { get; set; }
        [Column("CORREO_EJECUTIVO")]
        [StringLength(255)]
        public string CorreoEjecutivo { get; set; }

        [ForeignKey("IdCargaAlta")]
        [InverseProperty("BdNegociosIdCargaAltaNavigation")]
        public virtual BdCargas IdCargaAltaNavigation { get; set; }
        [ForeignKey("IdCargaStatus")]
        [InverseProperty("BdNegociosIdCargaStatusNavigation")]
        public virtual BdCargas IdCargaStatusNavigation { get; set; }
        [ForeignKey("IdEstado")]
        [InverseProperty("BdNegocios")]
        public virtual SepomexEstados IdEstadoNavigation { get; set; }
        [ForeignKey("IdHorarioAcceso")]
        [InverseProperty("BdNegociosIdHorarioAccesoNavigation")]
        public virtual CHorarios IdHorarioAccesoNavigation { get; set; }
        [ForeignKey("IdHorarioUptime")]
        [InverseProperty("BdNegociosIdHorarioUptimeNavigation")]
        public virtual CHorarios IdHorarioUptimeNavigation { get; set; }
        [InverseProperty("IdNegocioNavigation")]
        public virtual ICollection<BdInstalaciones> BdInstalaciones { get; set; }
        [InverseProperty("IdNegocioNavigation")]
        public virtual ICollection<BdNegocioHorasMes> BdNegocioHorasMes { get; set; }
        [InverseProperty("IdNegocioNavigation")]
        public virtual ICollection<BdRetiros> BdRetiros { get; set; }
        [InverseProperty("IdNegocioNavigation")]
        public virtual ICollection<BdSustituciones> BdSustituciones { get; set; }
    }
}
