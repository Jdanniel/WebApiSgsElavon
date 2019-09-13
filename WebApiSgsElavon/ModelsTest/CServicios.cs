using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CServicios
    {
        public CServicios()
        {
            BdServicioCausa = new HashSet<BdServicioCausa>();
            BdServicioSolucion = new HashSet<BdServicioSolucion>();
        }

        public int IdServicio { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoServicio { get; set; }
        public int? IdMoneda { get; set; }
        public int? IdTipoPrecio { get; set; }
        public string DescServicio { get; set; }
        public string Codigo { get; set; }
        public int? MinPromedio { get; set; }
        public int? IsInsumosRequired { get; set; }
        public int? IsCausaSolucionRequired { get; set; }
        public int? IsCausaRequired { get; set; }
        public int? IsSolucionRequired { get; set; }
        public int? IsTasRequired { get; set; }
        public int? IsOtorganteTasRequired { get; set; }
        public int? IsNoEquipoRequired { get; set; }
        public int? IsNoSerieRequired { get; set; }
        public int? IsNoInventarioRequired { get; set; }
        public int? IsIdModeloRequired { get; set; }
        public int? IsFecLlegadaRequired { get; set; }
        public int? IsFecLlegadaTercerosRequired { get; set; }
        public int? IsFolioServicioRequired { get; set; }
        public int? IsFecIniIngenieroRequired { get; set; }
        public int? IsFecFinIngenieroRequired { get; set; }
        public int? IsOtorganteVoboRequired { get; set; }
        public int? IsOtorganteVoboTercerosRequired { get; set; }
        public int? IsIntensidadSenialRequired { get; set; }
        public int? IsIsSimRemplazadaRequired { get; set; }
        public int? IsFolioServicioRechazoRequired { get; set; }
        public int? IsOtorganteVoboRechazoRequired { get; set; }
        public int? IsFallaEncontradaRequired { get; set; }
        public int? IsOtorganteVoboClienteRequired { get; set; }
        public int? IsMotivoCobroRequired { get; set; }
        public int? IsIsSoporteClienteRequired { get; set; }
        public int? IsOtorganteSoporteClienteRequired { get; set; }
        public int? IsIsBoletinRequired { get; set; }
        public int? IsCadenaCierreEscritaRequired { get; set; }
        public int? IsDowntime { get; set; }
        public int? IsCodigoIntervencionRequired { get; set; }
        public int? LengthCodigoIntervencion { get; set; }
        public int? IsIdTipoFallaEncontradaRequired { get; set; }
        public int? IsIdentificaAgendadosRequired { get; set; }
        public int? IsDescripcionTrabajoRechazoRequired { get; set; }
        public int? IsCierrePda { get; set; }
        public int? IsInstalacionLlavesRequired { get; set; }
        public int? IsStatusInstalacionLlavesRequired { get; set; }
        public int? IsNombrePersonaLlavesARequired { get; set; }
        public int? IsNombrePersonaLlavesBRequired { get; set; }
        public int? IsTipoPwRequired { get; set; }
        public int? IsTipoTecladoRequired { get; set; }
        public int? IsVersionTecladoEppRequired { get; set; }
        public int? IsProcesadorRequired { get; set; }
        public int? IsVelocidadProcesadorRequired { get; set; }
        public int? IsMemoriaRequired { get; set; }
        public int? IsCapacidadDiscoDuroRequired { get; set; }
        public int? IsMonitorRequired { get; set; }
        public int? IsLectorTarjetaRequired { get; set; }
        public int? IsOtorganteVoboIngPartnerRequired { get; set; }
        public int? IsFecLlegadaIngPartnerRequired { get; set; }
        public int? IsReporteServicioPartnerRequired { get; set; }
        public int? IsIsValidacionAlarmasRequired { get; set; }
        public int? IsIsInstalacionPlacaFrontalRequired { get; set; }
        public int? IsIsInstalacionPlacaLateralRequired { get; set; }
        public int? IsIsBlindajeTuercaSeguridadRequired { get; set; }
        public int? IsIs2TaquetesAdicionalesRequired { get; set; }
        public int? IsIsSustitucion4TuercasRequired { get; set; }
        public int? IsIsFotografiasRequired { get; set; }
        public int? IsMultipleTask { get; set; }
        public int? IsPrefacturacionIsCobrable { get; set; }
        public int? IsPrefacturacionIsRetipificado { get; set; }
        public int? IsPrefacturacionAgendado { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IsTipoLlaveRequired { get; set; }
        public int? IsDvRequired { get; set; }
        public int? IsAlertReincidente { get; set; }
        public int? IsReportReincidente { get; set; }
        public int? IsAplicacionRequired { get; set; }
        public int? IsVersionRequired { get; set; }
        public int? IsCajaRequired { get; set; }
        public string RequisitosServicio { get; set; }
        public int? IsLecturaVoltajeRequired { get; set; }
        public int? IsFolioValidacionRequired { get; set; }
        public int? IsFolioTirRequired { get; set; }
        public int? IsEspecificaTipoFalla { get; set; }
        public int? IsIdCausaRechazoRequired { get; set; }
        public int? IsEspecificaCausaRechazoRequired { get; set; }
        public int? MinTablero { get; set; }
        public int? IsDescTrabajoRequired { get; set; }
        public int? IsDescTrabajoCatalogoRequired { get; set; }
        public string IdCategoriaValidaDispositivos { get; set; }
        public string RequestType { get; set; }
        public int? IsXmlElavon { get; set; }
        public int? IsWarrantyDays { get; set; }
        public int? IsCourtSchedule { get; set; }
        public int? IsAsignacionAuto { get; set; }
        public int? NeedNoSim { get; set; }
        public int? NeedClaveRechazo { get; set; }
        public int? IdArneedNocheckup { get; set; }
        public int? IdArneedFile { get; set; }
        public int? IdArreopen { get; set; }
        public int? IsFallaEncontradaCatalogoRequired { get; set; }
        public int? IsHorarioGarantia { get; set; }
        public int? IsMinutosGarantia { get; set; }
        public int? KitInsumo { get; set; }
        public int? NeedKit { get; set; }
        public int? IsEmailServiceCharge { get; set; }
        public int? IsReglaDuplicado { get; set; }
        public int? IsProyecto { get; set; }
        public int? NoDias { get; set; }
        public int? IsCallCenter { get; set; }

        public virtual CMonedas IdMonedaNavigation { get; set; }
        public virtual CTipoPrecio IdTipoPrecioNavigation { get; set; }
        public virtual CTipoServicio IdTipoServicioNavigation { get; set; }
        public virtual ICollection<BdServicioCausa> BdServicioCausa { get; set; }
        public virtual ICollection<BdServicioSolucion> BdServicioSolucion { get; set; }
    }
}
