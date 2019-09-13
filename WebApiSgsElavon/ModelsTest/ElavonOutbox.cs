using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class ElavonOutbox
    {
        public int IdElavonOutbox { get; set; }
        public int? IdEnvioElavon { get; set; }
        public int? IdAr { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Status { get; set; }
        public string RequestId { get; set; }
        public string RequestStatus { get; set; }
        public string StatusReasonCode { get; set; }
        public string StatusReason { get; set; }
        public string Comments { get; set; }
        public string BookingDt { get; set; }
        public string ServiceReceivedBy { get; set; }
        public string Mid { get; set; }
        public string Tid { get; set; }
        public string Serial { get; set; }
        public string DeviceTypeCategory { get; set; }
        public string DeviceType { get; set; }
        public string AssignmentNoFrom { get; set; }
        public string AssignmentNo { get; set; }
        public string PurchaseOrderNo { get; set; }
        public string Profile { get; set; }
        public string Cabecera { get; set; }
    }
}
