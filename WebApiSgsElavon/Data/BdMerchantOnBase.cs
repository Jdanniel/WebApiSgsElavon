using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdMerchantOnBase
{
    public int MerchantOnBaseId { get; set; }

    public string Name { get; set; }

    public string Buc { get; set; }

    public string Rfc { get; set; }

    public string FisicalStreet { get; set; }

    public string Number { get; set; }

    public string District { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Country { get; set; }

    public string PostalCode { get; set; }

    public string RefPoint1 { get; set; }

    public string RefPoint2 { get; set; }

    public int? PhoneId { get; set; }

    public DateTime? CreateDate { get; set; }
}
