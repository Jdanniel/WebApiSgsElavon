using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdLoginUser
{
    public int Id { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string IpAddress { get; set; }

    public string UserAgent { get; set; }

    public DateTime? Date { get; set; }

    public string IpMachine { get; set; }
}
