using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_INGRESO_ARCHIVOS_EXITO")]
    public partial class BdIngresoArchivosExito
    {
        [Column("ID_ARCHIVO_MASIVO")]
        public int IdArchivoMasivo { get; set; }
        [Column("ID_ARCHIVO")]
        public int? IdArchivo { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ID_CAUSA")]
        public int? IdCausa { get; set; }
        [Column("ID_SOLUCION")]
        public int? IdSolucion { get; set; }
        [Column("DESCRIPCION_TRABAJO")]
        public string DescripcionTrabajo { get; set; }
        [Column("ATIENDE")]
        public string Atiende { get; set; }
        [Column("FEC_CIERRE", TypeName = "smalldatetime")]
        public DateTime? FecCierre { get; set; }
        [Column("HORA_CIERRE")]
        [StringLength(2)]
        public string HoraCierre { get; set; }
        [Column("MINUTO_CIERRE")]
        [StringLength(2)]
        public string MinutoCierre { get; set; }
        [Column("FOLIO_TAS")]
        public string FolioTas { get; set; }
        [Column("CODIGO_INTERVENCION")]
        public string CodigoIntervencion { get; set; }
        [Column("OTORGANTE_TAS")]
        public string OtorganteTas { get; set; }
        [Column("NO_EQUIPO")]
        public string NoEquipo { get; set; }
        [Column("NO_SERIE_FALLA")]
        public string NoSerieFalla { get; set; }
        [Column("NO_INVENTARIO_FALLA")]
        public string NoInventarioFalla { get; set; }
        [Column("ID_MODELO_FALLA")]
        public int? IdModeloFalla { get; set; }
        [Column("FEC_LLEGADA", TypeName = "smalldatetime")]
        public DateTime? FecLlegada { get; set; }
        [Column("HORA_LLEGADA")]
        [StringLength(2)]
        public string HoraLlegada { get; set; }
        [Column("MINUTO_LLEGADA")]
        [StringLength(2)]
        public string MinutoLlegada { get; set; }
        [Column("FEC_LLEGADA_TERCEROS", TypeName = "smalldatetime")]
        public DateTime? FecLlegadaTerceros { get; set; }
        [Column("HORA_LLEGADA_TERCEROS")]
        [StringLength(2)]
        public string HoraLlegadaTerceros { get; set; }
        [Column("MINUTO_LLEGADA_TERCERO")]
        [StringLength(2)]
        public string MinutoLlegadaTercero { get; set; }
        [Column("FOLIO_SERVICIO")]
        public string FolioServicio { get; set; }
        [Column("FEC_INI_INGENIERO", TypeName = "smalldatetime")]
        public DateTime? FecIniIngeniero { get; set; }
        [Column("HORA_INI_INGENIERO")]
        [StringLength(2)]
        public string HoraIniIngeniero { get; set; }
        [Column("MINUTO_INI_INGENIERO")]
        [StringLength(2)]
        public string MinutoIniIngeniero { get; set; }
        [Column("FEC_FIN_INGENIERO", TypeName = "smalldatetime")]
        public DateTime? FecFinIngeniero { get; set; }
        [Column("HORA_FIN_INGENIERO")]
        [StringLength(2)]
        public string HoraFinIngeniero { get; set; }
        [Column("MINUTO_FIN_INGENIERO")]
        [StringLength(2)]
        public string MinutoFinIngeniero { get; set; }
        [Column("OTORGANTE_VOBO")]
        public string OtorganteVobo { get; set; }
        [Column("OTORGANTE_VOBO_TERCEROS")]
        public string OtorganteVoboTerceros { get; set; }
        [Column("INTENSIDAD_SENIAL")]
        public string IntensidadSenial { get; set; }
        [Column("IS_SIM_REMPLAZADA")]
        public int? IsSimRemplazada { get; set; }
        [Column("DIGITO_VERIFICADOR")]
        public string DigitoVerificador { get; set; }
        [Column("ID_TIPO_FALLA_ENCONTRADA")]
        public int? IdTipoFallaEncontrada { get; set; }
        [Column("ID_ESPECIF_TIPO_FALLA")]
        public int? IdEspecifTipoFalla { get; set; }
        [Column("FALLA_ENCONTRADA")]
        public string FallaEncontrada { get; set; }
        [Column("OTORGANTE_VOBO_CLIENTE")]
        public string OtorganteVoboCliente { get; set; }
        [Column("VOLTAJE_NEUTRO")]
        public string VoltajeNeutro { get; set; }
        [Column("VOLTAJE_TIERRA")]
        public string VoltajeTierra { get; set; }
        [Column("VOLTAJE_TIERRA_NEUTRO")]
        public string VoltajeTierraNeutro { get; set; }
        [Column("FOLIO_VALIDACION")]
        public string FolioValidacion { get; set; }
        [Column("FOLIO_TIR")]
        public string FolioTir { get; set; }
        [Column("MOTIVO_COBRO")]
        public string MotivoCobro { get; set; }
        [Column("IS_SOPORTE_CLIENTE")]
        public int? IsSoporteCliente { get; set; }
        [Column("IS_BOLETIN")]
        public int? IsBoletin { get; set; }
        [Column("OTORGANTE_SOPORTE_CLIENTE")]
        public string OtorganteSoporteCliente { get; set; }
        [Column("IS_COBRABLE")]
        public int? IsCobrable { get; set; }
        [Column("PRECIO", TypeName = "numeric(18, 2)")]
        public decimal? Precio { get; set; }
        [Column("CADENA_CIERRE_ESCRITA")]
        public string CadenaCierreEscrita { get; set; }
        [Column("INSTALACION_LLAVES")]
        public string InstalacionLlaves { get; set; }
        [Column("TIPO_LLAVE")]
        public string TipoLlave { get; set; }
        [Column("STATUS_INSTALACION_LLAVES")]
        public string StatusInstalacionLlaves { get; set; }
        [Column("NOMBRE_PERSONA_LLAVES_A")]
        public string NombrePersonaLlavesA { get; set; }
        [Column("NOMBRE_PERSONA_LLAVES_B")]
        public string NombrePersonaLlavesB { get; set; }
        [Column("TIPO_PW")]
        public string TipoPw { get; set; }
        [Column("TIPO_TECLADO")]
        public string TipoTeclado { get; set; }
        [Column("VERSION_TECLADO_EPP")]
        public string VersionTecladoEpp { get; set; }
        [Column("PROCESADOR")]
        public string Procesador { get; set; }
        [Column("VELOCIDAD_PROCESADOR")]
        public string VelocidadProcesador { get; set; }
        [Column("MEMORIA")]
        public string Memoria { get; set; }
        [Column("CAPACIDAD_DISCO_DURO")]
        public string CapacidadDiscoDuro { get; set; }
        [Column("MONITOR")]
        public string Monitor { get; set; }
        [Column("LECTOR_TARJETA")]
        public string LectorTarjeta { get; set; }
        [Column("APLICACION")]
        public string Aplicacion { get; set; }
        [Column("VERSION")]
        public string Version { get; set; }
        [Column("CAJA")]
        public string Caja { get; set; }
        [Column("STATUS_ARCHIVO")]
        public string StatusArchivo { get; set; }
        [Column("ID_USUARIO_ALTA_ARCHIVO")]
        public int? IdUsuarioAltaArchivo { get; set; }
        [Column("FECHA_ALTA_ARCHIVO", TypeName = "smalldatetime")]
        public DateTime? FechaAltaArchivo { get; set; }
        [Column("DESC_ERROR")]
        public string DescError { get; set; }
        [Column("IS_MOV")]
        public int? IsMov { get; set; }
        [Column("NO_SERIE_ENTRADA")]
        public string NoSerieEntrada { get; set; }
        [Column("NO_SERIE_SALIDA")]
        public string NoSerieSalida { get; set; }
        [Column("STATUS_MOV")]
        public string StatusMov { get; set; }
        [Column("DESC_ERROR_MOV")]
        public string DescErrorMov { get; set; }
        [Column("NO_EQUIPO_MOV")]
        public string NoEquipoMov { get; set; }
        [Column("IS_DANIADA")]
        public int? IsDaniada { get; set; }
    }
}
