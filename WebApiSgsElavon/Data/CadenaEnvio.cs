using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CadenaEnvio
{
    public string CadenaEnviada { get; set; }

    public string Movimiento { get; set; }

    public string Afiliacion { get; set; }

    public string Banco { get; set; }

    public string TerId { get; set; }

    public string LimiteCashback { get; set; }

    public string LimiteDevolucion { get; set; }

    public string LimiteVenta { get; set; }

    public string Ubicacion { get; set; }

    public string Modelo { get; set; }

    public string Aplicacion { get; set; }

    public string Plan { get; set; }

    public string VentaForzada { get; set; }

    public string Operativa { get; set; }

    public string Prepropina { get; set; }

    public string Postpropina { get; set; }

    public string DevolucionId { get; set; }

    public string Instalador { get; set; }

    public string ClaveDelCarrierTcpIp { get; set; }

    public string ClaveDelProtocoloTcpIp { get; set; }

    public string ClaveMin { get; set; }

    public string Usuario { get; set; }

    public string NumeroDeRegistro { get; set; }

    public string ConsecutivoComercio { get; set; }

    public string Observaciones { get; set; }

    public string IndicadorDeQps { get; set; }

    public string CierreAutomatico { get; set; }

    public string HoraInicioCierreManual { get; set; }

    public string HoraFinCierreManual { get; set; }

    public string IndicadoresAbmC4Subcampo9 { get; set; }

    public string IndicadoresAbmC4Subcampo6 { get; set; }

    public string IdentificadorGetnet { get; set; }

    public string NoArSf { get; set; }

    public string NoAr { get; set; }

    public string FolioTir { get; set; }

    public DateTime? FecEnvio { get; set; }
}
