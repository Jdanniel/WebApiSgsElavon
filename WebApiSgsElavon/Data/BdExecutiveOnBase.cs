using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdExecutiveOnBase
{
    public int ExecutiveOnBaseId { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public DateTime? CreateDate { get; set; }
}
