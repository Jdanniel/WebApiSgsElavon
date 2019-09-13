using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class ElavonInbox
    {
        public int IdElavonInbox { get; set; }
        public int? IdRecepcionElavon { get; set; }
        public string Status { get; set; }
        public string RequestId { get; set; }
        public string RequestType { get; set; }
        public string Tid { get; set; }
        public string Mid { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string CountyDistrict { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public string Contact { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Comments { get; set; }
        public string DueBy { get; set; }
        public string Terminal3DigitNumber { get; set; }
        public string Colony { get; set; }
        public string AttentionWindow { get; set; }
        public string Serial { get; set; }
        public string PurchaseType { get; set; }
        public string SimCardCarrier { get; set; }
        public string ConnectionType { get; set; }
        public string ExternalTid { get; set; }
        public string DeviceType { get; set; }
        public string DeviceTypeCategory { get; set; }
        public int? IdCliente { get; set; }
        public int? IdServicio { get; set; }
        public int? IdFalla { get; set; }
        public int? IdProyecto { get; set; }
        public int? IsFollowDispatch { get; set; }
    }
}
