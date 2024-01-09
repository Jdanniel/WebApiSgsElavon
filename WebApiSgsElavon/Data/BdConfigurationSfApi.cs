using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdConfigurationSfApi
{
    public int Id { get; set; }

    public int? ValidateStates { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? UserId { get; set; }
}
