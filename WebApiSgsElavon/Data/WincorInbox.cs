using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class WincorInbox
{
    public int IdInbox { get; set; }

    public string XmlString { get; set; }

    public DateTime? Fecha { get; set; }

    public string IncidentNumber { get; set; }

    public string TaskNumber { get; set; }

    public string TaskAssignmentId { get; set; }

    public string HelpdeskNumber { get; set; }

    public string CustomerName { get; set; }

    public int? IdCliente { get; set; }

    public string Severity { get; set; }

    public int? IdSegmento { get; set; }

    public string Urgency { get; set; }

    public string NoAfiliacion { get; set; }

    public string Telefono { get; set; }

    public string Direccion { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Cp { get; set; }

    public string SerialNumber { get; set; }

    public string Request { get; set; }

    public int? IdServicio { get; set; }

    public string DefectDescription { get; set; }

    public int? IdFalla { get; set; }

    public string Comentarios { get; set; }

    public DateTime? PlannedStartDate { get; set; }

    public DateTime? PlannedEndDate { get; set; }

    public string Status { get; set; }

    public int? ManualInputHold { get; set; }

    public DateTime? FecRecibido { get; set; }

    public int? IsFollowDispatch { get; set; }

    public string NotasRemedy { get; set; }

    public int? IdProyecto { get; set; }

    public string OriginalCustomerReference { get; set; }

    public DateTime? FecCarga { get; set; }
}
