using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdEnviosProsaAbc
{
    public int IdEnviosProsaAbc { get; set; }

    public string NoAfiliacionCadena { get; set; }

    public string NoAfiliacionAr { get; set; }

    public int? IdAr { get; set; }

    public string Estatus { get; set; }

    public string Comentario { get; set; }

    public DateTime? FecEnvio { get; set; }

    public DateTime? FecRecibido { get; set; }

    public string NombreArchivoEntrada { get; set; }

    public string NombreArchivoSalida { get; set; }

    public string EstatusProsa { get; set; }

    public int? IdNegocio { get; set; }

    public string CadenaEnviada { get; set; }

    public string CadenaRecibida { get; set; }

    public int? IdBitacoraMovimientosAbc { get; set; }

    public int? CorteRecibido { get; set; }
}
