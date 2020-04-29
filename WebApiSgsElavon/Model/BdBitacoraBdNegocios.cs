using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_BD_NEGOCIOS")]
    public partial class BdBitacoraBdNegocios
    {
        [Column("ID_BITACORA_BD_NEGOCIOS")]
        public int IdBitacoraBdNegocios { get; set; }
        [Column("ID_NEGOCIO")]
        public int? IdNegocio { get; set; }
        [Column("NO_AFILIACION_ANTERIOR")]
        public string NoAfiliacionAnterior { get; set; }
        [Column("NO_AFILIACION_ACTUAL")]
        public string NoAfiliacionActual { get; set; }
        [Column("ID_ZONA_ANTERIOR")]
        public int? IdZonaAnterior { get; set; }
        [Column("ID_ZONA_ACTUAL")]
        public int? IdZonaActual { get; set; }
        [Column("ID_REGION_ANTERIOR")]
        public int? IdRegionAnterior { get; set; }
        [Column("ID_REGION_ACTUAL")]
        public int? IdRegionActual { get; set; }
        [Column("ID_CLIENTE_ANTERIOR")]
        public int? IdClienteAnterior { get; set; }
        [Column("ID_CLIENTE_ACTUAL")]
        public int? IdClienteActual { get; set; }
        [Column("ID_SEGMENTO_ANTERIOR")]
        public int? IdSegmentoAnterior { get; set; }
        [Column("ID_SEGMENTO_ACTUAL")]
        public int? IdSegmentoActual { get; set; }
        [Column("DESC_NEGOCIO_ANTERIOR")]
        public string DescNegocioAnterior { get; set; }
        [Column("DESC_NEGOCIO_ACTUAL")]
        public string DescNegocioActual { get; set; }
        [Column("TELEFONO_ANTERIOR")]
        public string TelefonoAnterior { get; set; }
        [Column("TELEFONO_ACTUAL")]
        public string TelefonoActual { get; set; }
        [Column("DIRECCION_ANTERIOR")]
        public string DireccionAnterior { get; set; }
        [Column("DIRECCION_ACTUAL")]
        public string DireccionActual { get; set; }
        [Column("COLONIA_ANTERIOR")]
        public string ColoniaAnterior { get; set; }
        [Column("COLONIA_ACTUAL")]
        public string ColoniaActual { get; set; }
        [Column("POBLACION_ANTERIOR")]
        public string PoblacionAnterior { get; set; }
        [Column("POBLACION_ACTUAL")]
        public string PoblacionActual { get; set; }
        [Column("ESTADO_ANTERIOR")]
        public string EstadoAnterior { get; set; }
        [Column("ESTADO_ACTUAL")]
        public string EstadoActual { get; set; }
        [Column("CP_ANTERIOR")]
        public string CpAnterior { get; set; }
        [Column("CP_ACTUAL")]
        public string CpActual { get; set; }
        [Column("ID_ESTADO_ANTERIOR")]
        public int? IdEstadoAnterior { get; set; }
        [Column("ID_ESTADO_ACTUAL")]
        public int? IdEstadoActual { get; set; }
        [Column("LATITUD_ANTERIOR")]
        public string LatitudAnterior { get; set; }
        [Column("LATITUD_ACTUAL")]
        public string LatitudActual { get; set; }
        [Column("LONGITUD_ANTERIOR")]
        public string LongitudAnterior { get; set; }
        [Column("LONGITUD_ACTUAL")]
        public string LongitudActual { get; set; }
        [Column("ID_HORARIO_UPTIME_ANTERIOR")]
        public int? IdHorarioUptimeAnterior { get; set; }
        [Column("ID_HORARIO_UPTIME_ACTUAL")]
        public int? IdHorarioUptimeActual { get; set; }
        [Column("ID_HORARIO_ACCESO_ANTERIOR")]
        public int? IdHorarioAccesoAnterior { get; set; }
        [Column("ID_HORARIO_ACCESO_ACTUAL")]
        public int? IdHorarioAccesoActual { get; set; }
        [Column("ID_TIPO_COBRO_NEGOCIO_ANTERIOR")]
        public int? IdTipoCobroNegocioAnterior { get; set; }
        [Column("ID_TIPO_COBRO_NEGOCIO_ACTUAL")]
        public int? IdTipoCobroNegocioActual { get; set; }
        [Column("ID_MONEDA_ANTERIOR")]
        public int? IdMonedaAnterior { get; set; }
        [Column("ID_MONEDA_ACTUAL")]
        public int? IdMonedaActual { get; set; }
        [Column("STATUS_ANTERIOR")]
        public string StatusAnterior { get; set; }
        [Column("STATUS_ACTUAL")]
        public string StatusActual { get; set; }
        [Column("PRECIO_ANTERIOR")]
        public string PrecioAnterior { get; set; }
        [Column("PRECIO_ACTUAL")]
        public string PrecioActual { get; set; }
        [Column("FEC_ALTA_IGUALA_ANTERIOR", TypeName = "datetime")]
        public DateTime? FecAltaIgualaAnterior { get; set; }
        [Column("FEC_ALTA_IGUALA_ACTUAL", TypeName = "datetime")]
        public DateTime? FecAltaIgualaActual { get; set; }
        [Column("FEC_BAJA_IGUALA_ANTERIOR", TypeName = "datetime")]
        public DateTime? FecBajaIgualaAnterior { get; set; }
        [Column("FEC_BAJA_IGUALA_ACTUAL", TypeName = "datetime")]
        public DateTime? FecBajaIgualaActual { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
