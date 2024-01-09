using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdInformacionUnidadAr
{
    public int IdInformacionUnidadAr { get; set; }

    public int? IdAr { get; set; }

    public string InstalacionLlaves { get; set; }

    public string StatusInstalacionLlaves { get; set; }

    public string NombrePersonaLlavesA { get; set; }

    public string NombrePersonaLlavesB { get; set; }

    public string TipoPw { get; set; }

    public string TipoTeclado { get; set; }

    public string VersionTecladoEpp { get; set; }

    public string Procesador { get; set; }

    public string VelocidadProcesador { get; set; }

    public string Memoria { get; set; }

    public string CapacidadDiscoDuro { get; set; }

    public string Monitor { get; set; }

    public string LectorTarjeta { get; set; }

    public string TipoLlave { get; set; }

    public string Aplicacion { get; set; }

    public string Version { get; set; }
}
