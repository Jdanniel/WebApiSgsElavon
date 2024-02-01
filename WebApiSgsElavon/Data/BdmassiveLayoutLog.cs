using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdmassiveLayoutLog
{
    public int MassiveLayoutId { get; set; }

    public string Layout { get; set; }

    public string FiltersJson { get; set; }

    public int? UserId { get; set; }

    public DateTime? DateDischarge { get; set; }
}
