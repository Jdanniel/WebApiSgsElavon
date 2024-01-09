using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdIngresoMovInventariosLog
{
    public int IdIngresoMovInventariosLog { get; set; }

    public string Odt { get; set; }

    public string InstalacionNoSerie { get; set; }

    public string InstalacionModelo { get; set; }

    public string ConectividadEntrada { get; set; }

    public string AplicativoEntrada { get; set; }

    public string RetiroNoSerie { get; set; }

    public string RetiroModelo { get; set; }

    public string ConectividadSalida { get; set; }

    public string AplicativoSalida { get; set; }

    public string MarcaMantto { get; set; }

    public string ModeloMantto { get; set; }

    public string TecnologiaMantto { get; set; }

    public string NoSerieMantto { get; set; }

    public string Bateria { get; set; }

    public string Eliminador { get; set; }

    public string Base { get; set; }

    public string Tapa { get; set; }

    public string CableAc { get; set; }

    public string IdAr { get; set; }

    public string RetiroIdUnidad { get; set; }

    public string InstalacionIdUnidad { get; set; }

    public string IdInstalacionModelo { get; set; }

    public string IdRetiroModelo { get; set; }

    public string IdConectividadEntrada { get; set; }

    public string IdConectividadSalida { get; set; }

    public string IdAplicativoEntrada { get; set; }

    public string IdAplicativoSalida { get; set; }

    public int? IdBdIngresoMovInventarios { get; set; }

    public int? IdArchivo { get; set; }
}
