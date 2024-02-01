using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdArCierreManual
{
    public int IdCierreManual { get; set; }

    public int? IdAr { get; set; }

    public string NoSerieInstalacion { get; set; }

    public int? IdConectividadInstalacion { get; set; }

    public int? IdAplicativoInstalacion { get; set; }

    public string VersionInstalacion { get; set; }

    public string ArchivoTerminalInstalacion { get; set; }

    public int? SeDejaMismoSim { get; set; }

    public string SimExistente { get; set; }

    public string SimInstalacion { get; set; }

    public int? IdCarrierInstalacion { get; set; }

    public string ArchivoSimInstalacion { get; set; }

    public int? IdMarcaRetiro { get; set; }

    public int? IdModeloRetiro { get; set; }

    public string NoSerieRetiro { get; set; }

    public int? IdAplicativoRetiro { get; set; }

    public int? IdConectividadRetiro { get; set; }

    public string VersionRetiro { get; set; }

    public string ArchivoTerminalRetiro { get; set; }

    public int? NoSeRetiraSim { get; set; }

    public string SimSinRetirar { get; set; }

    public string SimRetiro { get; set; }

    public int? IdCarrierRet { get; set; }

    public string ArchivoSimRetirado { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string Atiende { get; set; }

    public string OtorganteVobo { get; set; }

    public int? IdTipoAtencion { get; set; }

    public int? IdCriterioCambio { get; set; }

    public int? RollosInstalados { get; set; }

    public int? IdTecnico { get; set; }

    public string Discover { get; set; }

    public string IsAmex { get; set; }

    public string ConclusionesAmex { get; set; }

    public int? IdAmex { get; set; }

    public int? AfiliacionAmex { get; set; }

    public string ComentariosServicio { get; set; }

    public int? IdSerieCambioConect { get; set; }

    public int? IdMarcaCambioConect { get; set; }

    public int? IdModeloCambioConect { get; set; }

    public int? IdConectividadCambioConect { get; set; }

    public string VersionCambioConect { get; set; }

    public int? IdAplicativoCambioConect { get; set; }

    public string NoSerieCambioConect { get; set; }

    public string RetiroSimCambioConect { get; set; }

    public string SimCambioConect { get; set; }

    public int? IdCarrierCambioConect { get; set; }

    public string ArchivoCambioConect { get; set; }

    public int? IdConectividadCambioConectNueva { get; set; }

    public int? IdConectividadCambioConectNuevaExiste { get; set; }

    public string Estatus { get; set; }

    public string TipoMovimiento { get; set; }

    public int? Caja { get; set; }

    public int? UsuarioId { get; set; }

    public string Bateria { get; set; }

    public string Eliminador { get; set; }

    public string Tapa { get; set; }

    public string CableAc { get; set; }

    public string Base { get; set; }

    public string BateriaRet { get; set; }

    public string EliminadorRet { get; set; }

    public string TapaRet { get; set; }

    public string CableAcRet { get; set; }

    public string BaseRet { get; set; }

    public int? IdCierreMasivo { get; set; }

    public string Origen { get; set; }

    public string Getnet { get; set; }

    public string IdAccesoriosInstalados { get; set; }

    public string IdAccesoriosRetirados { get; set; }
}
