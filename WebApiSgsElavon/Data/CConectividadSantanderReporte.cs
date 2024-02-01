using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CConectividadSantanderReporte
{
    public int? IdMarca { get; set; }

    public string DescMarca { get; set; }

    public int? IdModelo { get; set; }

    public string DescModelo { get; set; }

    public string Tecnologia { get; set; }

    public string Activouobsoleto { get; set; }

    public string Aplicativo { get; set; }

    public string Conectividad { get; set; }

    public string TerminalesCifradas { get; set; }

    public string VersionCifrada { get; set; }

    public string ModeloHomologado { get; set; }
}
