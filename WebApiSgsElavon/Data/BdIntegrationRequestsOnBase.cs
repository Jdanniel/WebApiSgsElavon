using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdIntegrationRequestsOnBase
{
    public Guid IntegrationRequestOnBaseId { get; set; }

    public string NumFolio { get; set; }

    public string Channel { get; set; }

    public string SignType { get; set; }

    public int? MerchantOnBaseId { get; set; }

    public int? LegalRepresentativeOnBaseId { get; set; }

    public int? SellerOnBaseId { get; set; }

    public int? ExecutiveOnBaseId { get; set; }

    public DateTime? CreateDate { get; set; }
}
