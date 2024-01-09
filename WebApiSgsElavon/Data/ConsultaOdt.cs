using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class ConsultaOdt
{
    public int IdAr { get; set; }

    public string NoAr { get; set; }

    public string NoAfiliacion { get; set; }

    public DateTime? FecAlta { get; set; }

    public DateTime? FecInicio { get; set; }

    public DateTime? FecCierre { get; set; }

    public DateTime? FecGarantia { get; set; }

    public DateTime? FecAtencion { get; set; }

    public string Status { get; set; }

    public string Afiliacion { get; set; }

    public string Direccion { get; set; }

    public string DireccionAlternaComercio { get; set; }

    public string Responsable { get; set; }

    public string Telefono { get; set; }

    public string TelefonoComercio { get; set; }

    public string PersonaAtenderaComercio { get; set; }

    public int? AgregarDias { get; set; }

    public TimeOnly? HoraAtencionIni { get; set; }

    public TimeOnly? HoraAtencionFin { get; set; }

    public int? Lunes { get; set; }

    public int? Martes { get; set; }

    public int? Miercoles { get; set; }

    public int? Jueves { get; set; }

    public int? Viernes { get; set; }

    public int? Sabado { get; set; }

    public int? Domingo { get; set; }

    public string NoSerie { get; set; }

    public int TerminalAmex { get; set; }

    public string Proveedor { get; set; }

    public string Tecnico { get; set; }

    public string Odt { get; set; }

    public string TipoDeServicio { get; set; }

    public string SubTipoDeServicio { get; set; }

    public int? RollosSolicitados { get; set; }

    public string FolioTelecarga { get; set; }

    public string Caja { get; set; }

    public string Producto { get; set; }

    public int IsProgramado { get; set; }

    public string Descripcion { get; set; }

    public string CadenaCierre { get; set; }

    public string TipoRechazo { get; set; }

    public string Zona { get; set; }

    public string IdTerminalAmex { get; set; }

    public string AfiliacionTerminalAmex { get; set; }

    public string Bitacora { get; set; }

    public string UsuarioCierre { get; set; }

    public string DescripcionTrabajo { get; set; }

    public string Segmento { get; set; }

    public string TipoCarga { get; set; }
}
