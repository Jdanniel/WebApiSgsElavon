using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdArExtension
{
    public int Id { get; set; }

    public int? IdAr { get; set; }

    public string OtorganteVoboIngPartner { get; set; }

    public DateTime? FecLlegadaIngPartner { get; set; }

    public string ReporteServicioPartner { get; set; }

    public int? IsValidacionAlarmas { get; set; }

    public string PersonalBanco { get; set; }

    public int? IsInstalacionPlacaFrontal { get; set; }

    public string MotivoInstalacionPlacaFrontal { get; set; }

    public int? IsInstalacionPlacaLateral { get; set; }

    public string MotivoInstalacionPlacaLateral { get; set; }

    public int? IsBlindajeTuercaSeguridad { get; set; }

    public string MotivoBlindajeTuercaSeguridad { get; set; }

    public int? Is2TaquetesAdicionales { get; set; }

    public string Motivo2TaquetesAdicionales { get; set; }

    public int? IsSustitucion4Tuercas { get; set; }

    public string MotivoSustitucion4Tuercas { get; set; }

    public int? IsFotografias { get; set; }

    public string MotivoFotografias { get; set; }
}
