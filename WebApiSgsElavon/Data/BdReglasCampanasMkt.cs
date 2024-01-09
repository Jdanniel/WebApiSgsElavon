using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdReglasCampanasMkt
{
    public int IdReglaCampanaMkt { get; set; }

    public string Nombre { get; set; }

    public int? IdDatoListaMailjet { get; set; }

    public int? IdTemplateMailjet { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }

    public int? IdProducto { get; set; }

    public DateTime? FecCierreIni { get; set; }

    public DateTime? FecCierreFin { get; set; }

    public DateTime? FecIniEnvio { get; set; }

    public bool IsRecurrente { get; set; }

    public int? IdTipoRecurrencia { get; set; }

    public bool Status { get; set; }

    public int? IdEmisorEmail { get; set; }

    public int? Dias { get; set; }

    public DateTime? FecUltimoEnvio { get; set; }

    public int? IdStatusAr { get; set; }

    public string EmailPrueba { get; set; }
}
