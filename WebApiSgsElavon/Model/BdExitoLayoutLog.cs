using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_EXITO_LAYOUT_LOG")]
    public partial class BdExitoLayoutLog
    {
        [Column("ID_EXITO_LAYOUT_LOG")]
        public int IdExitoLayoutLog { get; set; }
        [Column("ID_ARCHIVO_MASIVO")]
        public int? IdArchivoMasivo { get; set; }
        [Column("ODTEXTERNA", TypeName = "varchar(max)")]
        public string Odtexterna { get; set; }
        [Column("CIERRE_SERVICIO", TypeName = "varchar(max)")]
        public string CierreServicio { get; set; }
        [Column("ATIENDE", TypeName = "varchar(max)")]
        public string Atiende { get; set; }
        [Column("FECHA_CIERRE", TypeName = "varchar(max)")]
        public string FechaCierre { get; set; }
        [Column("HORAS_CIERRE")]
        public int? HorasCierre { get; set; }
        [Column("MINUTO_CIERRE")]
        public int? MinutoCierre { get; set; }
        [Column("OTORGANTE_VOBO", TypeName = "varchar(max)")]
        public string OtorganteVobo { get; set; }
        [Column("APLICACION")]
        public string Aplicacion { get; set; }
        [Column("VERSION")]
        public string Version { get; set; }
        [Column("CAJA")]
        public string Caja { get; set; }
        [Column("INSTALACIONES_ELAVON_DESC_MARCA")]
        public string InstalacionesElavonDescMarca { get; set; }
        [Column("INSTALACIONES_ELAVON_DESC_MODELO")]
        public string InstalacionesElavonDescModelo { get; set; }
        [Column("TECNOLOGIA_ENTRADA")]
        public string TecnologiaEntrada { get; set; }
        [Column("INSTALACIONES_ELAVON_NO_SERIE")]
        public string InstalacionesElavonNoSerie { get; set; }
        [Column("RETIROS_ELAVON_DESC_MARCA")]
        public string RetirosElavonDescMarca { get; set; }
        [Column("RETIROS_ELAVON_DESC_MODELO")]
        public string RetirosElavonDescModelo { get; set; }
        [Column("TECNOLOGIA_SALIDA")]
        public string TecnologiaSalida { get; set; }
        [Column("RETIROS_ELAVON_NO_SERIE")]
        public string RetirosElavonNoSerie { get; set; }
        [Column("MARCA_MANTTO")]
        public string MarcaMantto { get; set; }
        [Column("MODELO_MANTTO")]
        public string ModeloMantto { get; set; }
        [Column("TECNOLOGIA_MANTTO")]
        public string TecnologiaMantto { get; set; }
        [Column("NO_SERIE_MANTTO")]
        public string NoSerieMantto { get; set; }
        [Column("OTORGANTE_VOBO_RECHAZO", TypeName = "varchar(max)")]
        public string OtorganteVoboRechazo { get; set; }
        [Column("SUBRECHAZO", TypeName = "varchar(max)")]
        public string Subrechazo { get; set; }
        [Column("ID_CAUSA_CANCELACION", TypeName = "varchar(max)")]
        public string IdCausaCancelacion { get; set; }
        [Column("ESTATUS", TypeName = "varchar(max)")]
        public string Estatus { get; set; }
        [Column("CORREO", TypeName = "varchar(max)")]
        public string Correo { get; set; }
        [Column("BATERIA")]
        public string Bateria { get; set; }
        [Column("ELIMINADOR")]
        public string Eliminador { get; set; }
        [Column("BASE")]
        public string Base { get; set; }
        [Column("TAPA")]
        public string Tapa { get; set; }
        [Column("CABLE_AC")]
        public string CableAc { get; set; }
        [Column("TICKET")]
        public string Ticket { get; set; }
        [Column("TIPO_ATENCION", TypeName = "varchar(max)")]
        public string TipoAtencion { get; set; }
        [Column("AMEX_SI_NO")]
        public string AmexSiNo { get; set; }
        [Column("CONCLUSIONES_AMEX")]
        public string ConclusionesAmex { get; set; }
        [Column("IDAMX")]
        public string Idamx { get; set; }
        [Column("AFILAMX")]
        public string Afilamx { get; set; }
        [Column("IDRECHAZO", TypeName = "varchar(max)")]
        public string Idrechazo { get; set; }
        [Column("TELEFONO_CAMPO", TypeName = "varchar(max)")]
        public string TelefonoCampo { get; set; }
        [Column("ACT_REFERENCIAS")]
        public string ActReferencias { get; set; }
        [Column("IDCRITERIOCAMBIO", TypeName = "varchar(max)")]
        public string Idcriteriocambio { get; set; }
        [Column("DISCOVER", TypeName = "varchar(max)")]
        public string Discover { get; set; }
        [Column("MARCASIME")]
        public string Marcasime { get; set; }
        [Column("SIMENTRA")]
        public string Simentra { get; set; }
        [Column("MARCASIMS")]
        public string Marcasims { get; set; }
        [Column("SIMSALE")]
        public string Simsale { get; set; }
        [Column("ROLLOSINST")]
        public string Rollosinst { get; set; }
        [Column("VERSION2")]
        public string Version2 { get; set; }
        [Column("CORREO_ENVIADO")]
        public string CorreoEnviado { get; set; }
        [Column("ID_ARCHIVO")]
        public int? IdArchivo { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("IS_PROMOCIONES")]
        public string IsPromociones { get; set; }
        [Column("IS_APP")]
        public string IsApp { get; set; }
        [Column("IS_COMERCIO_NOTIFADO")]
        public string IsComercioNotifado { get; set; }
        [Column("TELEFONO_COMERCIO_1")]
        public string TelefonoComercio1 { get; set; }
        [Column("TELEFONO_COMERCIO_2")]
        public string TelefonoComercio2 { get; set; }
        [Column("IS_SMC")]
        public int? IsSmc { get; set; }
    }
}
