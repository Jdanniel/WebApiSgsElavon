using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_EXTENSION")]
    public partial class BdArExtension
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("OTORGANTE_VOBO_ING_PARTNER")]
        [StringLength(255)]
        public string OtorganteVoboIngPartner { get; set; }
        [Column("FEC_LLEGADA_ING_PARTNER", TypeName = "smalldatetime")]
        public DateTime? FecLlegadaIngPartner { get; set; }
        [Column("REPORTE_SERVICIO_PARTNER")]
        [StringLength(50)]
        public string ReporteServicioPartner { get; set; }
        [Column("IS_VALIDACION_ALARMAS")]
        public int? IsValidacionAlarmas { get; set; }
        [Column("PERSONAL_BANCO")]
        [StringLength(255)]
        public string PersonalBanco { get; set; }
        [Column("IS_INSTALACION_PLACA_FRONTAL")]
        public int? IsInstalacionPlacaFrontal { get; set; }
        [Column("MOTIVO_INSTALACION_PLACA_FRONTAL")]
        [StringLength(255)]
        public string MotivoInstalacionPlacaFrontal { get; set; }
        [Column("IS_INSTALACION_PLACA_LATERAL")]
        public int? IsInstalacionPlacaLateral { get; set; }
        [Column("MOTIVO_INSTALACION_PLACA_LATERAL")]
        [StringLength(255)]
        public string MotivoInstalacionPlacaLateral { get; set; }
        [Column("IS_BLINDAJE_TUERCA_SEGURIDAD")]
        public int? IsBlindajeTuercaSeguridad { get; set; }
        [Column("MOTIVO_BLINDAJE_TUERCA_SEGURIDAD")]
        [StringLength(255)]
        public string MotivoBlindajeTuercaSeguridad { get; set; }
        [Column("IS_2_TAQUETES_ADICIONALES")]
        public int? Is2TaquetesAdicionales { get; set; }
        [Column("MOTIVO_2_TAQUETES_ADICIONALES")]
        [StringLength(255)]
        public string Motivo2TaquetesAdicionales { get; set; }
        [Column("IS_SUSTITUCION_4_TUERCAS")]
        public int? IsSustitucion4Tuercas { get; set; }
        [Column("MOTIVO_SUSTITUCION_4_TUERCAS")]
        [StringLength(50)]
        public string MotivoSustitucion4Tuercas { get; set; }
        [Column("IS_FOTOGRAFIAS")]
        public int? IsFotografias { get; set; }
        [Column("MOTIVO_FOTOGRAFIAS")]
        [StringLength(255)]
        public string MotivoFotografias { get; set; }
    }
}
