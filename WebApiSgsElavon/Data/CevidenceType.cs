using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApiSgsElavon.Data;

public partial class CevidenceType
{
    [JsonPropertyName("EvidenceTypeId")]
    public int EvidenceTypeId { get; set; }
    [JsonPropertyName("EvidenceDesc")]

    public string EvidenceDesc { get; set; }
    [JsonPropertyName("Status")]

    public int? Status { get; set; }
    [JsonPropertyName("UserId")]

    public int? UserId { get; set; }
    [JsonPropertyName("CreateDate")]

    public DateTime? CreateDate { get; set; }
    [JsonPropertyName("EvidenceNumber")]

    public int? EvidenceNumber { get; set; }
}
