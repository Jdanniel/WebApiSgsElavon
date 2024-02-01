using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdPhonesOnBase
{
    public int PhoneId { get; set; }

    public string CountryCode { get; set; }

    public string AreaCode { get; set; }

    public string Number { get; set; }
}
