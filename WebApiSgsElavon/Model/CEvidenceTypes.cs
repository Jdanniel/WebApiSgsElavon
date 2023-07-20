using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Model
{
    public partial class CEvidenceTypes
    {
        public int EvidenceTypeId { get; set; }
        public string EvidenceDesc { get; set; }
        public int Status { get; set; }
        public int UserId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
